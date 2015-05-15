using HtmlParser.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolAnalizer
{
    public class MDot
    {
        private const string DesktopUserAgent =
            "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36";

        private const string MobileUserAgent =
            "Mozilla/5.0 (Linux; U; Android 2.1; en-us; GT-I9000 Build/ECLAIR) AppleWebKit/525.10+ (KHTML, like Gecko) Version/3.0.4 Mobile Safari/523.12.2";

        private static string GetResponseHost(IPHostEntry host, string userAgent)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
                var response = client.GetAsync("http://" + host.HostName).Result;
                return response.RequestMessage.RequestUri.Host;
            }
        }

        public static string MDotTest(IPHostEntry host)
        {
            var mobile = GetResponseHost(host, MobileUserAgent);
            var desktop = GetResponseHost(host, DesktopUserAgent);
            return desktop != mobile ? mobile : null;
        }
    }
}
