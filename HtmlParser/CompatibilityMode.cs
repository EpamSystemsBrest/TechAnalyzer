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
        private static readonly char[] Simbol = {'@', '\'','"'};
        private static readonly Regex Regex = new Regex("-//w3c//dtd html 4.01 (Transitional|Frameset)//(en)?",
            RegexOptions.IgnoreCase);

        private static readonly Regex RegexForLimit = new Regex(@"(-//W3C//DTD XHTML 1.0 (Frameset|Transitional)//(en)?)|(-//w3c//dtd html 4.01 (Transitional|Frameset)//(en)?)",
            RegexOptions.IgnoreCase);

        private static readonly Regex RegexForQuirks =
            new Regex(
                //@"(-//IETF//DTD HTML(\s(2.0|2.1E|3.2|3.0|3|3.2 Final))?(\sStrict)?(\sLevel [0-3])?//(en)?)" +
                @"(-//IETF//DTD HTML(\s(2.0 Level [1-2]|2.0 Strict Level [1-2]|2.0 Strict|2.0|2.1E|3.0|3.2 Final|3.2|3|Level [0-3]|Strict Level [0-3]|Strict))?//(en)?)"+
                @"|(\+//Silmaril//dtd html Pro v0r11 19970101//)|(-//AdvaSoft Ltd//DTD HTML 3.0 asWedit \+ extensions//)" +
                @"|(-//AS//DTD HTML 3.0 asWedit \+ extensions//)|(-//Metrius//DTD Metrius Presentational//)" +
                @"|(-//Microsoft//DTD Internet Explorer [2-3].0 (HTML Strict|HTML|Tables))" +
                @"|(-//Netscape Comm. Corp.//DTD(\sStrict)? HTML)" +
                @"|(-//O'Reilly and Associates//DTD HTML (2.0|((Extended|Extended Relaxed) 1.0)))" +
                @"|(-//SoftQuad(\sSoftware)?//DTD HoTMetaL PRO (6.0|4.0)::(19990601|19971010)::extensions to HTML 4.0//(en)?)" +
                @"|(-//Spyglass//DTD HTML 2.0 Extended//)|(-//SQ//DTD HTML 2.0 HoTMetaL \+ extensions//)" +
                @"|(-//Sun Microsystems Corp.//DTD HotJava((\sStrict\s)|(\s))HTML//)" +
                //@"|(-(//|/)(W3C|W3O)(//|/)DTD(\sW3)? HTML(\s3|\s[3-4].(2|2S|0))?(\s1995-03-24)?" +
                //@"(\s(Draft|Final|Frameset|Transitional|Experimental|Strict))?(\s19960712|\s970421|\s3.0//EN|/EN)?//)" +
                @"(-(//|/)W3C(//|/)DTD HTML(\s((3 1995-03-24)|(3.2 Draft)|(3.2 Final)|(3.2)|(3.2S Draft)|(4.0 Frameset)|(4.0 transitional)|(Experimental 19960712)|(Experimental 970421)|(Strict 3.0)))(//|/)(en)?)|(-(//|/)W3O(//|/)DTD W3 HTML (3.0)?//(en)?)" +
                @"|(-//WebTechs//DTD Mozilla HTML(\s2.0)?//)", // +
                //@"|(aol hometown//html 3.0 transitional//en)",
                RegexOptions.IgnoreCase);

        private static readonly Regex RegexForSpecificDoctype = new Regex(@"(doctype( html (public|system)?)?)$" +
                                                                          @"|(""http://www.ibm.com/data/dtd/v11/ibmxhtml1-transitional.dtd"")", RegexOptions.IgnoreCase);

        public static CompatibilityModeDoctype GetCompatibilityModeFromDoctype(string doctype)
        {

            if (doctype.Equals("doctype html") || doctype.Equals(@"doctype html public """))
                return CompatibilityModeDoctype.NoQuirks;

            if (RegexForSpecificDoctype.IsMatch(doctype)) return CompatibilityModeDoctype.Quirks;

            var separator = Simbol.Where(doctype.Contains).FirstOrDefault();
            var items =
                doctype.Split(separator)
                    .Where(
                        x =>
                            !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x)).ToArray();

            var publicId = items.ElementAt(1);
     
            if (RegexForQuirks.IsMatch(publicId) || (Regex.IsMatch(publicId) && items.Count() < 3))
                return CompatibilityModeDoctype.Quirks;
            return RegexForLimit.IsMatch(publicId)
                ? CompatibilityModeDoctype.LimitedQuirks
                : CompatibilityModeDoctype.NoQuirks;
        }
    }
}
