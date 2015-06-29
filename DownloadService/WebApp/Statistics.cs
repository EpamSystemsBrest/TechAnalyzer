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
        private readonly object objLock = new object();

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

        [DataMember]
        private DateTime newTime;

        [DataMember]
        private DateTime pauseTime;

        [IgnoreDataMember]
        private ServiseStatus status;

        public void DownloadStarted(string url) {
            CurrentUrl.Add(url);
        }

        #pragma warning disable 0420, 3021
        [CLSCompliant(false)]
        public void DownloadFinished(string url, long size) {
            lock (objLock) {
                CountByte += size;
            }
            Interlocked.Increment(ref CountDownloadUrl);
            AdressList.Add(url);
            CurrentUrl.TryTake(out url);
        }

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
                СountThead = Process.GetCurrentProcess().Threads.Count,
                Speed = string.Format("{0:F3} {1}", GetDownloadSpeed(), "КB/s")
            };
        }
    }
}
