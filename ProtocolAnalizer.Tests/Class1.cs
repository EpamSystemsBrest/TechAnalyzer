using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProtocolAnalizer;

namespace ProtocolAnalizer.Tests
{
    public class Class1
    {
        [Fact]
        public void ParseServerNameMustReturnCorrectResult()
        {
            Assert.Equal(HttpServerName.Apache,HttpHeaders.ParseServerName("Apache"));
            Assert.Equal(HttpServerName.IIS, HttpHeaders.ParseServerName("IIS"));
            Assert.Equal(HttpServerName.LiteSpeed, HttpHeaders.ParseServerName("LiteSpeed"));
            Assert.Equal(HttpServerName.Apache, HttpHeaders.ParseServerName("aPaChE"));
            Assert.Equal(HttpServerName.Other, HttpHeaders.ParseServerName("Apaache"));
        }

        [Fact]
        public void ParseServerNameMustThrowArgumentNullException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => HttpHeaders.ParseServerName(null));
            Assert.Equal("Value cannot be null.", ex.Message);
        }
    }
}
