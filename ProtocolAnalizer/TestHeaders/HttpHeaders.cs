using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProtocolAnalizer
{
    public enum HttpServerName
    {
        Other = 0,
        Apache = 1,
        IIS = 2,
        nginx = 3,
        GSE = 4,
        LiteSpeed = 5,
        lighttpd = 6,
        uServ = 7,
        ATS = 8,
        IBM = 9,
        YTS = 10
    }

    public class HttpHeaders
    {
        static Regex regex = new Regex(@"(apache)|(iis[\W]|^iis)|(nginx)|(gse[\W]|^gse)|(litespeed)|(lighttpd)|(userv)|(ats[\W]|^ATS)|(ibm)|(yts)", RegexOptions.IgnoreCase);
        public static HttpServerName ParseServerName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }
            var groups = regex.Match(name).Groups;
            for (int i = 1; i < groups.Count; i++)
            {
                if (!string.IsNullOrEmpty(groups[i].Value))
                {
                    return (HttpServerName)(i);
                }
            }
            return HttpServerName.Other;
        }
    }
}
