using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class Service
    {
        public static DateTime StartTime;
        public static volatile int CountDownloadUrl;
        private static long _countByte;
        private static readonly string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly object objLock = new object();
        public static readonly ConcurrentBag<string> CurrentUrl = new ConcurrentBag<string>();
        public static volatile ConcurrentBag<string> AdressList = new ConcurrentBag<string>();
        private readonly Action<Uri, Stream, Encoding> _action;
        public static double Speed { get { return GetDownloadSpeed(); } }
        private static IEnumerable<string> Adress { get { return GenerateAdressList("url.txt"); } }

        private readonly Dictionary<string, Encoding> _myEncodings = new Dictionary<string, Encoding>
        {
            {"UTF-8", Encoding.UTF8},
            {"UTF-16", Encoding.Unicode},
            {"ASCII", Encoding.ASCII},
            {"UTF-32", Encoding.UTF32},
            {"UTF-7", Encoding.UTF7}
        };

        public Service(Action<Uri, Stream, Encoding> action)
        {
            _action = action;
        }

        private static IEnumerable<string> GenerateAdressList(string url)
        {
            using (var stream = new StreamReader(BaseDirectory + url))
            {
                string line;
                while (!string.IsNullOrEmpty(line = stream.ReadLine()))
                {
                    yield return line;
                }
            }
        }

        private void ParseContextFromUrl(string url)
        {
            try
            {
                var adress = "http://" + url;
                var request = WebRequest.CreateHttp(adress);
                request.AllowAutoRedirect = true;
                using (var response = (HttpWebResponse) request.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    using (var reader = new StreamReader(stream))
                    {
                        var result = reader.ReadToEnd();
                        _countByte = Interlocked.Add(ref _countByte, Encoding.UTF8.GetByteCount(result));
                        _action.Invoke(new Uri(adress), stream, GetEncoding(response));
                    }
                }
            }
            catch (Exception ex)
            {
                Log(string.Join(":", url, ex.Message));
            }
        }

        private Encoding GetEncoding(HttpWebResponse response)
        {
            return _myEncodings.FirstOrDefault(
                x =>
                    x.Key.Equals(response.CharacterSet,
                        StringComparison.InvariantCultureIgnoreCase)).Value ?? Encoding.UTF8;
        }

        public void DownloadContext()
        {
            StartTime = DateTime.Now;
            CountDownloadUrl = GetCountDownloadUrl();
            Parallel.ForEach(Adress.Except(AdressList), url =>
            {
                CurrentUrl.Add(url);
                ParseContextFromUrl(url);
                Interlocked.Increment(ref CountDownloadUrl);
                AdressList.Add(url);
                CurrentUrl.TryTake(out url);
            });
            File.WriteAllText(BaseDirectory + "list.txt", string.Empty);
            File.WriteAllText(BaseDirectory + "count.txt", string.Empty);
        }

        private static double GetDownloadSpeed()
        {
            var resultSecond = Math.Abs((DateTime.Now - StartTime).TotalSeconds);
            var speedByte = _countByte/resultSecond;
            return speedByte/1024;
        }

        private static int GetCountDownloadUrl()
        {
            using (var str = new StreamReader(BaseDirectory + "count.txt"))
            {
                return Convert.ToInt32(str.ReadLine());
            }
        }

        public static void Log(string message)
        {
            lock (objLock)
            {
                File.AppendAllText(BaseDirectory + "log.txt",
                    string.Format("{0}:{1}\r\n", DateTime.Now, message));
            }
        }
    }
}
