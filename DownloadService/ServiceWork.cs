using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DownloadService.ServiseState;

namespace DownloadService
{
    public class ServiceWork
    {
        private Statistics Statistic { get; set; }

        private readonly Action<Uri, Stream, Encoding> _action;
        public bool IsFinished;

        public ServiceWork(Action<Uri, Stream, Encoding> action, Statistics statistic)
        {
            Statistic = statistic;
            _action = action;
        }

        private IEnumerable<string> GenerateAdressList()
        {
            using (var stream = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "url.txt"))
            {
                string line;
                while (!string.IsNullOrEmpty(line = stream.ReadLine()))
                {
                    yield return line;
                }
            }
        }

        private long ParseContextFromUrl(string url)
        {
            try
            {
                var adress = string.Format("{0}{1}{2}", Uri.UriSchemeHttp, Uri.SchemeDelimiter, url);
                var request = WebRequest.CreateHttp(adress);
                request.AutomaticDecompression = DecompressionMethods.GZip;
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    if (_action != null) _action(new Uri(adress), stream, GetEncoding(response));
                    return response.ContentLength;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(string.Join(":", url, ex.Message));
                return 0;
            }
        }

        private static Encoding GetEncoding(HttpWebResponse response)
        {
            return response.CharacterSet == null ? Encoding.UTF8 : Encoding.GetEncoding(response.CharacterSet);
        }

        public void DownloadContext()
        {
            var isDone = Parallel.ForEach(GenerateAdressList().Except(Statistic.AdressList), (url, state) =>
            {
                Statistic.DownloadStarted(url);
                var size = ParseContextFromUrl(url);
                Statistic.DownloadFinished(url, size);
                if (IsFinished) state.Break();
            }).IsCompleted;

            if (!isDone) return;
            Statistic.Status = ServiseStatus.Done;
            ServiceStateSerializer.ServiseStateClear();
        }
    }
}
