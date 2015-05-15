using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProtocolAnalizer;
using Xunit.Sdk;

namespace ProtocolAnalizer.Tests
{
    public class HttpHeadersTest
    {

        [Theory]
        [InlineData("Apache", HttpServerName.Apache)]
        [InlineData("Apache/2.2.3 (CentOS)", HttpServerName.Apache)]
        [InlineData("Apache-Coyote/1.1", HttpServerName.Apache)]
        [InlineData(".V01 Apache", HttpServerName.Apache)]
        [InlineData("Apache/2.2.24 (Unix) mod_ssl/2.2.24 OpenSSL/1.0.0-fips mod_auth_passthrough/2.1 mod_bwlimited/1.4 FrontPage/5.0.2.2635", HttpServerName.Apache)]

        [InlineData("IIS", HttpServerName.IIS)]
        [InlineData("Microsoft-IIS/7.5", HttpServerName.IIS)]
        [InlineData("Microsoft-IIS/6.0", HttpServerName.IIS)]
        [InlineData("Microsoft-IIS/6.0,WebSphere Application Server/6.1", HttpServerName.IIS)]
        [InlineData("Oracle Application Server/10g (10.1.2) Microsoft-IIS/6.0 OracleAS-Web-Cache-10g/10.1.2.0.2 (N;ecid=72071959521272998,0)", HttpServerName.IIS)]
        [InlineData("Microsoft-IIS/7.5,Apache", HttpServerName.IIS)]

        [InlineData("nginx", HttpServerName.nginx)]
        [InlineData("cloudflare-nginx", HttpServerName.nginx)]
        [InlineData("FreeBSD 9.0 (Resin 5 + Nginx 1.3 + Varnish 4)", HttpServerName.nginx)]
        [InlineData("NGINX(CnPanel,LNMP)", HttpServerName.nginx)]
        [InlineData("Alibaba.com 1688.HK - Global Trade Starts Here.nginx/0.9.5", HttpServerName.nginx)]

        [InlineData("GSE", HttpServerName.GSE)]

        [InlineData("LiteSpeed", HttpServerName.LiteSpeed)]
        [InlineData("LiteSpeed  6", HttpServerName.LiteSpeed)]
        [InlineData("LiteSpeed/4.0.12 Enterprise", HttpServerName.LiteSpeed)]

        [InlineData("switchlighttpd/1.4.32.004", HttpServerName.lighttpd)]
        [InlineData("ispconfig/lighttpd@srv1.seatcupra.net", HttpServerName.lighttpd)]
        [InlineData("lighttpd/1.4.28", HttpServerName.lighttpd)]

        [InlineData("uServ/3.2.2", HttpServerName.uServ)]

        [InlineData("ATS", HttpServerName.ATS)]
        [InlineData("ATS/3.2.4", HttpServerName.ATS)]

        [InlineData("IBM_HTTP_Server", HttpServerName.IBM)]
        [InlineData("IBM_HTTP_Server/6.1.0.41 Apache/2.0.47", HttpServerName.IBM)]
        [InlineData("Oracle-Fusion-Middleware/11g (11.1.1.6) IBM_HTTP_Server Oracle-Web-Cache-11g/11.1.1.6.0 (N;ecid=9284137597871276,0", HttpServerName.IBM)]

        [InlineData("YTS/1.19.11", HttpServerName.YTS)]

        [InlineData("pgServer", HttpServerName.Other)]
        [InlineData("SnugServer", HttpServerName.Other)]
        [InlineData("Cheshire Catserver", HttpServerName.Other)]
        [InlineData("WhatServer", HttpServerName.Other)]
        [InlineData("Hostbehost/ChatServer/1.2.7", HttpServerName.Other)]
        [InlineData("Server", HttpServerName.Other)]
        [InlineData("QRATOR", HttpServerName.Other)]
        [InlineData("Lotus-Domino", HttpServerName.Other)]
        [InlineData("Zeus/4.3", HttpServerName.Other)]
        [InlineData("Oversee Turing v1.0.0", HttpServerName.Other)]
        [InlineData("AmazonS3", HttpServerName.Other)]

        public void ParseServerNameMustReturnCorrectResult(string serverName, HttpServerName expected) {
            var actual = HttpHeaders.ParseServerName(serverName);
            Assert.Equal(expected, actual);
        }
    }
}
