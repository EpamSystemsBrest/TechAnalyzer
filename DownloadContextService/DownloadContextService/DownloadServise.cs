using System;
using System.Collections.Concurrent;
using System.Configuration;
using System.IO;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using Microsoft.Owin.Hosting;
using ServiceLibrary;

namespace DownloadContextService
{
    public partial class DownloadServise : ServiceBase, IDisposable
    {
        private IDisposable _webLog;
        private readonly Thread _thead = new Thread(new Service(action).DownloadContext);
        private static readonly string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        private static readonly Action<Uri, Stream, Encoding> action = (uri, stream, encoding) =>
        {
            using (var reader = new StreamReader(stream, encoding))
            {
                reader.ReadToEnd();
            }
        };

        public DownloadServise()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ServicePointManager.DefaultConnectionLimit = 12;
            _webLog = WebApp.Start<Startup>(string.Format("{0}://{1}",
                ConfigurationManager.AppSettings["EndpointProtocol"],
                ConfigurationManager.AppSettings["EndpointPort"]));

            Service.Status = Service.ServiseStatus.Running;
            Service.Log("Servise start!");
            Service.AdressList = GetListUrl();
            _thead.Start();
        }

        protected override void OnStop()
        {
            _thead.Abort();
            SavePositions();
            Service.Log("Servise stop! It happened save state");
        }

        protected override void OnPause()
        {
            _thead.Abort();
            Service.Status = Service.ServiseStatus.Pause;
            SavePositions();
            Service.Log("Servise pause! It happened save state");
        }

        protected override void OnContinue()
        {
            Service.Log("Servise resume! Сontinue process with saved state");
            Service.AdressList = GetListUrl();
            Service.Status = Service.ServiseStatus.Running;
            new Thread(new Service(action).DownloadContext).Start();
        }

        protected override void OnShutdown()
        {
            _thead.Abort();
            SavePositions();
            Service.Log("Servise shutdown! Сontinue process with saved state");
        }

        private static void SavePositions()
        {
            try
            {
                SaveList();
                WriteToFile();
            }
            catch (Exception ex)
            {
                Service.Log("it is impossible to save the state" + ex.Message);
            }
        }

        private static void SaveList()
        {
            using (var stream = new StreamWriter(BaseDirectory + "list.txt"))
            {
                foreach (var x in Service.AdressList)
                {
                    stream.WriteLine(x);
                }
            }
        }

        private static void WriteToFile()
        {
            using (var stream = new StreamWriter(BaseDirectory + "save.txt"))
            {
                stream.WriteLine(Service.CountDownloadUrl.ToString());
                stream.WriteLine(Service.StartTime.ToString("G"));
                stream.WriteLine(Service.CountByte);
            }
        }

        private static ConcurrentBag<string> GetListUrl()
        {
            var list = new ConcurrentBag<string>();
            using (var stream = new StreamReader(BaseDirectory + "list.txt"))
            {
                string line;
                while (!string.IsNullOrEmpty(line = stream.ReadLine()))
                {
                    list.Add(line);
                }
            }
            return list;
        }

        public new void Dispose()
        {
            if (_webLog != null)
                _webLog.Dispose();
        }
    }
}