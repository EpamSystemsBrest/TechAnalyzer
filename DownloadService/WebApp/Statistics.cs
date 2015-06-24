using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.Serialization;
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
            Status = ServiseStatus.Running;
            CurrentUrl = new ConcurrentBag<string>();
            AdressList = new ConcurrentBag<string>();
        }

        [DataMember] 
        public DateTime StartTime;

        [IgnoreDataMember] 
        public ServiseStatus Status;

        [DataMember] 
        public volatile int CountDownloadUrl;

        [IgnoreDataMember] 
        public volatile ConcurrentBag<string> CurrentUrl;

        [DataMember] 
        public volatile ConcurrentBag<string> AdressList;

        [IgnoreDataMember]
        private int СountThead { get { return Process.GetCurrentProcess().Threads.Count; } }

        [IgnoreDataMember]
        private string Speed { get { return string.Format("{0:F3} {1}", GetDownloadSpeed(), "КB/s"); } }

        [DataMember]
        public long CountByte { get; set; }

        private double GetDownloadSpeed()
        {
            if (Status == ServiseStatus.Pause || Status == ServiseStatus.Done) return 0;
            var resultSecond = (DateTime.Now - StartTime).TotalSeconds;
            var speedByte = CountByte/resultSecond;
            return speedByte/1024;
        }

        public UsageDetails GetUsageDetails()
        {
            return new UsageDetails()
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
