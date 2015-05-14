using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProtocolAnalizer.Tests
{
    public class MDotTests
    {
        [Fact]
        public void MDotSupportTest()
        {
           var actual= MDot.MDotTest(Dns.GetHostEntry("twitter.com"));
           Assert.Equal("mobile.twitter.com", actual);
        }
    }
}
