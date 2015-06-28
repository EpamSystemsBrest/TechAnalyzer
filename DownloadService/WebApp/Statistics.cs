using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;
using DownloadService.ServiseState;
using Newtonsoft.Json.Converters;

namespace DownloadService
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd hh:mm:ss";
        }
    }

    [DataContract(Name = "Statistics")]
    public class Statistics
    {

        public Statistics()
        {
            StartTime = DateTime.Now;
            CurrentUrl = new ConcurrentBag<string>();
            AdressList = new ConcurrentBag<string>();
            newTime = DateTime.Now;
        }

        [DataMember]
        public DateTime StartTime;

        [DataMember]
        public volatile int CountDownloadUrl;

        [DataMember]
        public long CountByte { get; set; }

        [IgnoreDataMember]
        public volatile ConcurrentBag<string> CurrentUrl;

        [DataMember]
        public volatile ConcurrentBag<string> AdressList;

        [IgnoreDataMember]
        public string Speed { get { return string.Format("{0:F3} {1}", GetDownloadSpeed(), "КB/s"); } }

        [IgnoreDataMember]
        public ServiseStatus Status
        {
            private get { return status; }
            set
            {
                status = value;
                SetPauseTime(value);
                ChangeServiseState(value);
                SetNewTime(value);
            }
        }

        [IgnoreDataMember]
        private int СountThead { get { return Process.GetCurrentProcess().Threads.Count; } }

        [DataMember]
        private DateTime newTime;

        [DataMember]
        private DateTime pauseTime;

        [IgnoreDataMember]
        private ServiseStatus status;

        private void SetPauseTime(ServiseStatus value)
        {
            if (value == ServiseStatus.Pause)
                pauseTime = DateTime.Now;
        }

        private void SetNewTime(ServiseStatus value)
        {
            if (value == ServiseStatus.Resume)
            {
                newTime = DateTime.Now - (pauseTime - newTime);
            }
        }

        private void ChangeServiseState(ServiseStatus value)
        {
            if (value == ServiseStatus.Done) return;
            if (value != ServiseStatus.Running && value != ServiseStatus.Resume)
            {
                ServiceStateSerializer.SerializeServiceStateToXml(this);
                return;
            }

            var statistic = ServiceStateSerializer.DeserializeServiceState();
            CountDownloadUrl = statistic.CountDownloadUrl;
            AdressList = statistic.AdressList;
            StartTime = statistic.StartTime;
            CountByte = statistic.CountByte;
            newTime = statistic.newTime;
            pauseTime = statistic.pauseTime;
        }

        private double GetDownloadSpeed()
        {
            if (Status == ServiseStatus.Pause || Status == ServiseStatus.Done) return 0;

            var resultSecond = (DateTime.Now - newTime).TotalSeconds;
            var speedByte = CountByte / resultSecond;
            return speedByte / 1024;
        }

        public UsageDetails GetUsageDetails()
        {
            return new UsageDetails
            {
                StartTime = StartTime,
                CountDownloadUrl = CountDownloadUrl,
                CurrentUrl = CurrentUrl,
                Status = Status,
                СountThead = СountThead,
                Speed = Speed
            };
        }
    }
}
