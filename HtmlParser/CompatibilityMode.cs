using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HtmlParser
{
    public class CompatibilityMode
    {
        static int index = 0;

        public static string GetCompatibilityModeFromDoctype(string doctype)
        {
            if (doctype.Equals(@"Doctype: ""doctype""") || doctype.Equals(@"Doctype: ""doctype html public""") ||
                doctype.Equals(@"Doctype: ""doctype html system""") ||
                doctype.Contains("http://www.ibm.com/data/dtd/v11/ibmxhtml1-transitional.dtd")) return "Quirks";

            var item = doctype.Split('"');

            var regexForLimit = new Regex(@"-//W3C//DTD XHTML 1.0 (Frameset|Transitional)//", RegexOptions.IgnoreCase);
            var regexForQuirks =
                new Regex(
                    @"(-//IETF//DTD HTML(\s(2.0|2.1E|3.2|3.0|3|3.2 Final))?(\sStrict)?(\sLevel [0-3])?//)|(\+//Silmaril//dtd html Pro v0r11 19970101//)|(-//AdvaSoft Ltd//DTD HTML 3.0 asWedit \+ extensions//)|(-//AS//DTD HTML 3.0 asWedit \+ extensions//)|(-//Metrius//DTD Metrius Presentational//)|(-//Microsoft//DTD Internet Explorer [2-3].0 (HTML Strict|HTML|Tables))|(-//Netscape Comm. Corp.//DTD(\sStrict)? HTML)|(-//O'Reilly and Associates//DTD HTML (2.0|((Extended|Extended Relaxed) 1.0)))|(-//SoftQuad(\sSoftware)?//DTD HoTMetaL PRO (6.0|4.0)::(19990601|19971010)::extensions to HTML 4.0//)|(-//Spyglass//DTD HTML 2.0 Extended//)|(-//SQ//DTD HTML 2.0 HoTMetaL \+ extensions//)|(-//Sun Microsystems Corp.//DTD HotJava((\sStrict\s)|(\s))HTML//)|(-(//|/)(W3C|W3O)(//|/)DTD(\sW3)? HTML(\s3|\s[3-4].(2|2S|0))?(\s1995-03-24)?(\s(Draft|Final|Frameset|Transitional|Experimental|Strict))?(\s19960712|\s970421|\s3.0//EN|/EN)?//)|(-//WebTechs//DTD Mozilla HTML(\s2.0)?//)|(-//""aol hometown//html 3.0 transitional//en)",
                    RegexOptions.IgnoreCase);
            var r = new Regex("-//w3c//dtd html 4.01 (Transitional|Frameset)//(en)?", RegexOptions.IgnoreCase);

            if (regexForQuirks.IsMatch(item[2]) || (r.IsMatch(item[2]) && item.Length == 5)) return "Quirks";
            if (regexForLimit.IsMatch(item[2]) || (r.IsMatch(item[2]) && item.Length == 7)) return "Limited Quirks";

            return "No Quirks";
        }

    }
}
