using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolAnalizer.TestHeaders
{
    [Flags]
    public enum HeadersTest
    {
        None = 0,
        StrictTransportSecurity = 1 << 1,
        XPoweredBy = 1 << 2,
        Xhacker = 1 << 3,
        XNananana = 1 << 4,
        XPingback = 1 << 5,
        XPickUsInstead = 1 << 6,
        XPowered_By = 1 << 7,
        XGeek = 1 << 8,
        XAwesome = 1 << 9,
        XServerNickName = 1 << 10,
        XToynbeeIdea = 1 << 11,
        XGasHost = 1 << 12,
        XCookingWith = 1 << 13,
        XGasolineAge = 1 << 14,
        Guyito = 1 << 15,
        XServedBy = 1 << 16,
        XRecruiting = 1 << 17,
        XCoreMission = 1 << 18,
        XJobs = 1 << 19,
        XHire = 1 << 20,
        XSlogan = 1 << 21
    }

    public static class HeadersExtentions
    {

        public static Dictionary<string, HeadersTest> Headers = new Dictionary<string, HeadersTest>()
        {
            {@"not suppors this headers", HeadersTest.None},
            {@"Strict-Transport-Security", HeadersTest.StrictTransportSecurity},
            {@"X-PoweredBy", HeadersTest.XPoweredBy},
            {@"X-hacker", HeadersTest.Xhacker},
            {@"X-nananana", HeadersTest.XNananana},
            {@"X-Pingback", HeadersTest.XPingback},
            {@"X-PickUsInstead", HeadersTest.XPickUsInstead},
            {@"X-Powered-By", HeadersTest.XPowered_By},
            {@"X-Geek", HeadersTest.XGeek},
            {@"X-Awesome", HeadersTest.XAwesome},
            {@"X-ServerNickName", HeadersTest.XServerNickName},
            {@"X-Toynbee-Idea", HeadersTest.XToynbeeIdea},
            {@"X-GasHost", HeadersTest.XGasHost},
            {@"X-Cooking-With", HeadersTest.XCookingWith},
            {@"X-Gasoline-Age", HeadersTest.XGasolineAge},
            {@"Guyito", HeadersTest.Guyito},
            {@"X-Served-By", HeadersTest.XServedBy},
            {@"X-Recruiting", HeadersTest.XRecruiting},
            {@"X-Core-Mission", HeadersTest.XCoreMission},
            {@"X-Jobs", HeadersTest.XJobs},
            {@"X-Hire", HeadersTest.XHire},
            {@"X-Slogan", HeadersTest.XSlogan},
        };

        public static Tuple<string, HeadersTest> TestHost(string host)
        {
            var httpResponse = GetResponse(host);
            var result = Headers.Select(x => httpResponse.TestHostHeaders(x));

            return Tuple.Create(host, result.Aggregate((x, y) => x | y));
        }

        private static HeadersTest TestHostHeaders(this WebResponse response, KeyValuePair<string, HeadersTest> pair)
        {
            if (response.Headers[pair.Key] != null) return pair.Value;
            return HeadersTest.None;
        }

        private static WebResponse GetResponse(string host)
        {
            return WebRequest.CreateHttp(host).GetResponse();
        }
    }
}
