using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HtmlParser
{
    public class CompatibilityMode
    {
        public static string GetCompatibilityModeFromDoctype(string doctype)
        {


                //Regex regex = new Regex(@"(\+|-)?//(?<w3c>w3c)|(?<Silmaril>Silmaril)|(?<AdvaSoft>AdvaSoft Ltd)|(?<AS>AS)|(?<IETF>IETF)|(?<Metrius>Metrius)|(?<Microsoft>Microsoft)|(?<Netscape>Netscape Comm. Corp.)|(?<OReilly>O'Reilly and Associates)|(?<SoftQuad>SoftQuad \w{8})|(?<Spyglass>Spyglass)|(?<SQ>SQ)|(?<Microsystems>Sun Microsystems Corp.)|(?<W3O>W3O)|(?<WebTechs>WebTechs) |(HTML) (//|/)? (?<Silmaril>dtd html Pro v0r11 19970101) | (?<AdvaSoft>DTD HTML 3.0 asWedit + extensions) | (?<AS>DTD HTML 3.0 asWedit + extensions)");

          //  Regex regex = new Regex(@"[+-]//IETF//DTD HTML \d \w+//");

          //var a =  regex.IsMatch(@"-//IETF//DTD HTML Level//");
            //if (doctype.StartsWith("+//Silmaril//dtd html Pro v0r11 19970101//",
            //    StringComparison.OrdinalIgnoreCase)
            //    || doctype.StartsWith("-//AdvaSoft Ltd//DTD HTML 3.0 asWedit + extensions//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//AS//DTD HTML 3.0 asWedit + extensions//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML 2.0 Level 1//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML 2.0 Level 2//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML 2.0 Strict Level 1//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML 2.0 Strict Level 2//",
            //        StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//IETF//DTD HTML 2.0 Strict//",
            //            StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//IETF//DTD HTML 2.0//",
            //                StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML 2.1E//",
            //        StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//IETF//DTD HTML 3.0//",
            //            StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML 3.2 Final//",
            //        StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//IETF//DTD HTML 3.2//",
            //            StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//IETF//DTD HTML 3//",
            //                StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML Level 0//",
            //        StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//IETF//DTD HTML Level 1//",
            //            StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML Level 2//",
            //        StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//IETF//DTD HTML Level 3//",
            //            StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML Strict Level 0//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML Strict Level 1//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML Strict Level 2//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//IETF//DTD HTML Strict Level 3//",
            //        StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//IETF//DTD HTML Strict//",
            //            StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//IETF//DTD HTML//",
            //                StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Metrius//DTD Metrius Presentational//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Microsoft//DTD Internet Explorer 2.0 HTML Strict//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Microsoft//DTD Internet Explorer 2.0 HTML//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Microsoft//DTD Internet Explorer 2.0 Tables//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Microsoft//DTD Internet Explorer 3.0 HTML Strict//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Microsoft//DTD Internet Explorer 3.0 HTML//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Microsoft//DTD Internet Explorer 3.0 Tables//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Netscape Comm. Corp.//DTD HTML//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Netscape Comm. Corp.//DTD Strict HTML//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//O'Reilly and Associates//DTD HTML 2.0//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//O'Reilly and Associates//DTD HTML Extended 1.0//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//O'Reilly and Associates//DTD HTML Extended Relaxed 1.0//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//SoftQuad Software//DTD HoTMetaL PRO 6.0::19990601::extensions to HTML 4.0//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//SoftQuad//DTD HoTMetaL PRO 4.0::19971010::extensions to HTML 4.0//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Spyglass//DTD HTML 2.0 Extended//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//SQ//DTD HTML 2.0 HoTMetaL + extensions//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Sun Microsystems Corp.//DTD HotJava HTML//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//Sun Microsystems Corp.//DTD HotJava Strict HTML//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//W3C//DTD HTML 3 1995-03-24//",
            //        StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//W3C//DTD HTML 3.2 Draft//",
            //            StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//W3C//DTD HTML 3.2 Final//",
            //        StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//W3C//DTD HTML 3.2//",
            //            StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//W3C//DTD HTML 3.2S Draft//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//W3C//DTD HTML 4.0 Frameset//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.Contains("-//W3C//DTD HTML 4.0 Transitional//") ||
            //    doctype.StartsWith("-//W3C//DTD HTML Experimental 19960712//",
            //        StringComparison.OrdinalIgnoreCase) ||
            //    doctype.StartsWith("-//W3C//DTD HTML Experimental 970421//",
            //        StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//W3C//DTD W3 HTML//",
            //            StringComparison.OrdinalIgnoreCase) || doctype.StartsWith("-//W3O//DTD W3 HTML 3.0//",
            //                StringComparison.OrdinalIgnoreCase))
            //    return "Quirks";

            //if (doctype.StartsWith("-//W3C//DTD XHTML 1.0 Frameset//", StringComparison.InvariantCultureIgnoreCase)
            //    ||
            //    doctype.StartsWith("-//W3C//DTD XHTML 1.0 Transitional//", StringComparison.InvariantCultureIgnoreCase)
            //    || (doctype.StartsWith("-//W3C//DTD HTML 4.01 Frameset//", StringComparison.InvariantCultureIgnoreCase))
            //    ||
            //    (doctype.StartsWith("-//W3C//DTD HTML 4.01 Transitional//", StringComparison.InvariantCultureIgnoreCase)))
            //{
            //    return "Limited Quirks";

            //}
            return "No Quirks";
        }
    }
}
