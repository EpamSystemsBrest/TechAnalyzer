using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using DownloadService.ServiseState;
using Microsoft.Owin.Hosting;

namespace DownloadService
{
    public partial class DownloadService : ServiceBase, IDisposable
    {
        private Thread thead;
        private IDisposable webLog;
        private ServiceWork serviceWork;
        private Statistics statistic;

        private static readonly Action<Uri, Stream, Encoding> action = (uri, stream, encoding) =>
        {
            using (var reader = new StreamReader(stream, encoding))
            {
                reader.ReadToEnd();
            }
        };

        public DownloadService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ServicePointManager.DefaultConnectionLimit = 12;

            statistic = new Statistics
            {
                Status = ServiseStatus.Running
            };

            webLog = WebApp.Start(string.Format("{0}://{1}",
                ConfigurationManager.AppSettings["EndpointProtocol"],
                ConfigurationManager.AppSettings["EndpointPort"]), new Startup(statistic).Configuration);

            
            serviceWork = new ServiceWork(action, statistic);
            
            StartThread();

            Log.WriteLog("Servise start!");
        }

        protected override void OnStop()
        {
            FinishThread(ServiseStatus.Stop);
            Log.WriteLog("Servise stop! It happened save state");
        }

        protected override void OnPause()
        {
            FinishThread(ServiseStatus.Pause);
            Log.WriteLog("Servise pause! It happened save state");
        }

        protected override void OnContinue()
        {
            statistic.Status = ServiseStatus.Resume;
            StartThread();
            Log.WriteLog("Servise resume! Сontinue process with saved state");
        }

        protected override void OnShutdown()
        {
            FinishThread(ServiseStatus.Shutdown);
            Log.WriteLog("Servise shutdown! Сontinue process with saved state");
        }

        private void StartThread()
        {
            thead = new Thread(serviceWork.DownloadContext);
            thead.Start();
        }

        private void FinishThread(ServiseStatus status)
        {
            serviceWork.IsFinished = true;
            thead.Join();        // Wait when thread is finished
            statistic.Status = status;
            thead = null;
        }

        public new void Dispose()
        {
            if (webLog != null)
                webLog.Dispose();
        }
    }
}
