using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolAnalizer {

    public enum HttpServerName { 
        Other = 0,
        Apache = 1,
        IIS = 2,
        ngnix = 3,
        GSE = 4,
        LiteSpeed = 5,
        lighttpd = 6,
        uServ = 7,
        ATS = 8,
        IBM = 9,
        YTS = 10
    }
    
    public class HttpHeaders {

        public static HttpServerName ParseServerName(string name) {
            return HttpServerName.Other;
        }

    }
}
