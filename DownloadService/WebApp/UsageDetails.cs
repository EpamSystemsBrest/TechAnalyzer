using System;
using System.Collections.Concurrent;
using DownloadService.ServiseState;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DownloadService
{
    public class UsageDetails
    {
        [JsonConverter(typeof (CustomDateTimeConverter))]
        public DateTime StartTime { get; set; }

        [JsonConverter(typeof (StringEnumConverter))]
        public ServiseStatus Status { get; set; }

        public int CountDownloadUrl { get; set; }
        public ConcurrentBag<string> CurrentUrl { get; set; }
        public int СountThead { get; set; }
        public string Speed { get; set; }
    }
}
