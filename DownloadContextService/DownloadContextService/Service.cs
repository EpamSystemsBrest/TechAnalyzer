using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ServiceLibrary
{
    public static class Service
    {
        public static DateTime StartTime;
        public static int CountDownloadUrl;
        public static string CurrentUrl;
        private static int _countByte;
        public static double Speed { get { return GetDownloadSpeed(); } }
        private static IEnumerable<string> Adress { get { return GenerateAdressList(); } }

        private static IEnumerable<string> GenerateAdressList()
        {
            using (var stream = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\url.txt"))
            {
                string line;
                while (!string.IsNullOrEmpty(line = stream.ReadLine()))
                {
                    yield return line;
                }
            }
        }

        private static string GetContextFromUrl(string url)
        {
            using (var client = new WebClient())
            {
                try
                {
                    var result = client.DownloadString("http://" + url);
                    _countByte += Encoding.UTF8.GetByteCount(result);
                    return result;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public static void DownloadContext()
        {
            StartTime = DateTime.Now;
            foreach (var url in Adress.Skip(CountDownloadUrl))
            {
                CurrentUrl = url;
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "\\html\\" + url + ".txt",
                    GetContextFromUrl(url));
                CountDownloadUrl++;
            }
        }

        private static double GetDownloadSpeed()
        {
            var resultSecond = Math.Abs(DateTime.Now.Second - StartTime.Second);
            var speedByte = _countByte/resultSecond;
            return (double) speedByte/1024;
        }
    }
}
