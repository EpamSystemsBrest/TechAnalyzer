using System.Collections.Concurrent;

namespace ServiceLibrary
{
    public class LogInformation
    {
        public string StartTime { get; set; }
        public int CountDownloadUrl { get; set; }
        public ConcurrentBag<string> CurrentUrl { get; set; }
        public string Speed { get; set; }
        public int СountThead { get; set; }
    }
}
