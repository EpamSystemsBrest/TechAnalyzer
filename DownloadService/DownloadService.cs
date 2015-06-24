using System;
using System.Collections.Concurrent;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using DownloadService.ServiseState;
using Microsoft.Owin.Builder;
using Microsoft.Owin.Hosting;
using Owin;

namespace DownloadService
{
    public partial class DownloadService : ServiceBase, IDisposable
    {
        private Thread _thead;
        private IDisposable _webLog;
        private Statistics _statistic;
        private ServiceWork _serviceWork;

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
            _statistic = ServiceStateSerializer.DeserializeServiceState();
            _webLog = WebApp.Start(string.Format("{0}://{1}",
                ConfigurationManager.AppSettings["EndpointProtocol"],
                ConfigurationManager.AppSettings["EndpointPort"]), new Startup(_statistic).Configuration);

            _serviceWork = new ServiceWork(action, _statistic);
            _thead = new Thread(_serviceWork.DownloadContext);
            _thead.Start();
            Log.WriteLog("Servise start!");

        }

        protected override void OnStop()
        {
            _serviceWork.IsFinished = true;
            ServiceStateSerializer.SerializeServiceStateToXml(_statistic);
            Log.WriteLog("Servise stop! It happened save state");
        }

        protected override void OnPause()
        {
            _serviceWork.IsFinished = true;
            _statistic.Status = ServiseStatus.Pause;
            ServiceStateSerializer.SerializeServiceStateToXml(_statistic);
            Log.WriteLog("Servise pause! It happened save state");
        }

        protected override void OnContinue()
        {
            _serviceWork = new ServiceWork(action, _statistic);
            _thead = new Thread(_serviceWork.DownloadContext);
            _thead.Start();
            Log.WriteLog("Servise resume! Сontinue process with saved state");
        }

        protected override void OnShutdown()
        {
            _serviceWork.IsFinished = true;
            ServiceStateSerializer.SerializeServiceStateToXml(_statistic);
            Log.WriteLog("Servise shutdown! Сontinue process with saved state");
        }

        public new void Dispose()
        {
            if (_webLog != null)
                _webLog.Dispose();
        }
    }
}
