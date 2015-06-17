﻿using System;
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
        public static long CountByte;
        public static volatile int CountDownloadUrl;
        public static DateTime StartTime = DateTime.Now;
        public static ServiseStatus Status { get; set; }
        public static double Speed { get { return GetDownloadSpeed(); } }
        public static readonly ConcurrentBag<string> CurrentUrl = new ConcurrentBag<string>();
        public static volatile ConcurrentBag<string> AdressList = new ConcurrentBag<string>();

        private static readonly object objLock = new object();
        private static readonly string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static IEnumerable<string> Adress { get { return GenerateAdressList("url.txt"); } }
        private readonly Action<Uri, Stream, Encoding> _action;

        public enum ServiseStatus
        {
            Running = 1,
            Pause = 2,
            Done = 3
        }

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
                var adress = string.Format("{0}{1}{2}/", Uri.UriSchemeHttp, Uri.SchemeDelimiter, url);
                var request = WebRequest.CreateHttp(adress);
                request.AutomaticDecompression = DecompressionMethods.GZip;
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    CountByte = Interlocked.Add(ref CountByte, response.ContentLength);
                    if (_action != null) _action(new Uri(adress), stream, GetEncoding(response));
                }
            }
            catch (Exception ex)
            {
                Log(string.Join(":", url, ex.Message));
            }
        }

        private static Encoding GetEncoding(HttpWebResponse response)
        {
            return response.CharacterSet == null ? Encoding.UTF8 : Encoding.GetEncoding(response.CharacterSet);
        }

        public void DownloadContext()
        {
            GetSavePosition();
            Parallel.ForEach(Adress.Except(AdressList), url =>
            {
                CurrentUrl.Add(url);
                ParseContextFromUrl(url);
                Interlocked.Increment(ref CountDownloadUrl);
                AdressList.Add(url);
                CurrentUrl.TryTake(out url);
            });
            Status = ServiseStatus.Done;
            File.WriteAllText(BaseDirectory + "list.txt", string.Empty);
            File.WriteAllText(BaseDirectory + "save.txt", string.Empty);
        }

        private static double GetDownloadSpeed()
        {
            if (Status == ServiseStatus.Pause || Status == ServiseStatus.Done) return 0;
            var resultSecond = (DateTime.Now - StartTime).TotalSeconds;
            var speedByte = CountByte / resultSecond;
            return speedByte / 1024;
        }

        private static void GetSavePosition()
        {
            var path = BaseDirectory + "save.txt";
            if (new FileInfo(path).Length == 0) return;
            using (var str = new StreamReader(path))
            {
                CountDownloadUrl = int.Parse(str.ReadLine());
                StartTime = DateTime.Parse(str.ReadLine());
                CountByte = long.Parse(str.ReadLine());
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
