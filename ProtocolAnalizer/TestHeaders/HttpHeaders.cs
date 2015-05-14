﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProtocolAnalizer {

    public enum HttpServerName { 
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
    
    public class HttpHeaders {

        static Regex regex = new Regex(@"(apache)|(iis)|(nginx)|(gse)|(litespeed)|(lighttpd)|(userv)|(ats[,. \n|\r/])|(ibm)|(yts)", RegexOptions.IgnoreCase);
        public static HttpServerName ParseServerName(string name) {

            if (name == null)
            {
                throw new ArgumentNullException();
            }

            if (name.ToLower() == "ats") return HttpServerName.ATS;
            string aaa = regex.Match(name.Replace("Server","")).Value.ToLower();
            if (aaa.Contains("ats")) aaa = "ats";


            

            switch (aaa)
            {
                case "apache": return HttpServerName.Apache;
                case "iis": return HttpServerName.IIS;
                case "nginx": return HttpServerName.nginx;
                case "gse": return HttpServerName.GSE;
                case "litespeed": return HttpServerName.LiteSpeed;
                case "lighttpd": return HttpServerName.lighttpd;
                case "userv": return HttpServerName.uServ;
                case "ats": return HttpServerName.ATS;
                case "ibm": return HttpServerName.IBM;
                case "yts": return HttpServerName.YTS;
                case "": return HttpServerName.Other;
                default: throw new ArgumentException();
            }
        }

    }
}
