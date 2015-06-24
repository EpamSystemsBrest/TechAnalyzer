using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadService
{
    public class Log
    {
        public static void WriteLog(string message)
        {
            Trace.WriteLine(string.Format("{0}:{1}\r\n", DateTime.Now, message));
        }
    }
}
