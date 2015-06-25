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
        private Statistics statistic = new Statistics();

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

            webLog = WebApp.Start(string.Format("{0}://{1}",
                ConfigurationManager.AppSettings["EndpointProtocol"],
                ConfigurationManager.AppSettings["EndpointPort"]), new Startup(statistic).Configuration);

            statistic.Status = ServiseStatus.Running;
            serviceWork = new ServiceWork(action, statistic);
            thead = new Thread(serviceWork.DownloadContext);
            thead.Start();
            Log.WriteLog("Servise start!");

        }

        protected override void OnStop()
        {
            serviceWork.IsFinished = true;
            statistic.Status = ServiseStatus.Stop;
            Log.WriteLog("Servise stop! It happened save state");
        }

        protected override void OnPause()
        {
            serviceWork.IsFinished = true;
            statistic.Status = ServiseStatus.Pause;
            Log.WriteLog("Servise pause! It happened save state");
        }

        protected override void OnContinue()
        {
            statistic.Status = ServiseStatus.Resume;
            serviceWork = new ServiceWork(action, statistic);
            thead = new Thread(serviceWork.DownloadContext);
            thead.Start();
            Log.WriteLog("Servise resume! Сontinue process with saved state");
        }

        protected override void OnShutdown()
        {
            serviceWork.IsFinished = true;
            statistic.Status = ServiseStatus.Shutdown;
            Log.WriteLog("Servise shutdown! Сontinue process with saved state");
        }

        public new void Dispose()
        {
            if (webLog != null)
                webLog.Dispose();
        }
    }
}
