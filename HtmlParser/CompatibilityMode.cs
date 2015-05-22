using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HtmlParser
{
    public enum CompatibilityModeDoctype
    {
        NoQuirks = 0,
        Quirks = 1 << 1,
        LimitedQuirks = 1 << 2,

    }

    public static class CompatibilityMode
    {

        private static readonly Regex RegexForLimit =
            new Regex(
                @"((\w+\s+)+(""|')-//W3C//DTD XHTML 1.0 (Frameset|Transitional)//(en)?(""|'))" +
                @"|((\w+\s+)+(""|')-//w3c//dtd html 4.01 (Transitional|Frameset)//(en)?(""|'))",
                RegexOptions.IgnoreCase);

        private static readonly Regex RegexForQuirks =
            new Regex(
                @"(\S-(//|/)W3C(//|/)DTD HTML (3 1995-03-24|3.2 Draft|3.2 Final|3.2|3.2S Draft|4.0 Frameset|4.0 transitional|Experimental 19960712|Experimental 970421|Strict 3.0)(//|/)(en)?)" +
                @"|(\S-(//|/)W3O(//|/)DTD W3 HTML 3.0(//|/))" +
                @"|(\S-(//|/)W3C//DTD W3 HTML(//|/))" +
                @"|(\S-//IETF//DTD HTML(\s(2.0 Level [1-2]|2.0 Strict Level [1-2]|2.0 Strict|2.0|2.1E|3.0|3.2 Final|3.2|3|Level [0-3]|Strict Level [0-3]|Strict))?//)" +
                @"|(\S\+//Silmaril//dtd html Pro v0r11 19970101//)" +
                @"|(\S-//AdvaSoft Ltd//DTD HTML 3.0 asWedit \+ extensions//)" +
                @"|(\S-//AS//DTD HTML 3.0 asWedit \+ extensions//)" +
                @"|(\S-//Metrius//DTD Metrius Presentational//)" +
                @"|(\S-//Microsoft//DTD Internet Explorer [2-3].0 (HTML Strict|HTML|Tables))" +
                @"|(\S-//Netscape Comm. Corp.//DTD(\sStrict)? HTML)" +
                @"|(\S-//O'Reilly and Associates//DTD HTML (2.0|((Extended|Extended Relaxed) 1.0)))" +
                @"|(\S-//SoftQuad(\sSoftware)?//DTD HoTMetaL PRO (6.0|4.0)::(19990601|19971010)::extensions to HTML 4.0//)" +
                @"|(\S-//Spyglass//DTD HTML 2.0 Extended//)" +
                @"|(\S-//SQ//DTD HTML 2.0 HoTMetaL \+ extensions//)" +
                @"|(\S-//Sun Microsystems Corp.//DTD HotJava((\sStrict\s)|(\s))HTML//)" +
                @"|(\S-//WebTechs//DTD Mozilla HTML(\s2.0)?//)" +
                @"|(aol hometown//html 3.0 transitional//)" +
                @"|((\w+\s+)+(""|')-//w3c//dtd html 4.01 transitional//en(\D)?(""|')(\s)?(\D)?$)" +
                @"|((\w+\s+)+""-//w3c//dtd html 4.01 Frameset//(en)?""$)" +
                @"|(doctype( ("")?html (public(""/)?|system)?)?)$" +
                @"|(""http://www.ibm.com/data/dtd/v11/ibmxhtml1-transitional.dtd"")"
                , RegexOptions.IgnoreCase);

        private static readonly Regex RegexForNoQuirks =
            new Regex(@"(^doctype html$|^doctype html public ""$)");

        public static CompatibilityModeDoctype GetCompatibilityModeFromDoctype(string doctype)
        {
            if (RegexForNoQuirks.IsMatch(doctype)) return CompatibilityModeDoctype.NoQuirks;
            if (RegexForQuirks.IsMatch(doctype)) return CompatibilityModeDoctype.Quirks;

            return RegexForLimit.IsMatch(doctype)
                ? CompatibilityModeDoctype.LimitedQuirks
                : CompatibilityModeDoctype.NoQuirks;
        }
    }
}
