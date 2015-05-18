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
            var regex1 = new Regex(@"-//IETF//DTD HTML [0-3.E]+ (\w+|())(\d|())//"); 
            var regex2 = new Regex(@"\+//Silmaril//dtd html Pro v0r11 19970101//"); 
            var regex3 = new Regex(@"-//AdvaSoft Ltd//DTD HTML 3.0 asWedit + extensions//"); 
            var regex4 = new Regex(@"-//AS//DTD HTML 3.0 asWedit \+ extensions//"); 
            var regex5 = new Regex(@"-//Metrius//DTD Metrius Presentational//"); 
            var regex6 = new Regex(@"-//Microsoft//DTD Internet Explorer [2-3.0]+ \w+"); 
            var regex7 = new Regex(@"-//Netscape Comm. Corp.//DTD (\w+|())"); 
            var regex8 = new Regex(@"-//O'Reilly and Associates//DTD HTML (2.0|(\w+ 1.0))"); 
            var regex9 = new Regex(@"-//SoftQuad Software//DTD HoTMetaL PRO (6.0|4.0)::\d{8}::extensions to HTML 4.0//");
           
            var regex10 = new Regex(@"-//Spyglass//DTD HTML 2.0 Extended//");
            var regex11 = new Regex(@"-//SQ//DTD HTML 2.0 HoTMetaL \+ extensions//");
            var regex12 = new Regex(@"-//Sun Microsystems Corp.//DTD HotJava((\sStrict\s)|(\s))HTML//");
            var regex13 = new Regex(@"-//W3C//DTD(\sW3)? HTML(\s3|(\s[3-4].(2|2S|0)))(\s(\d{4})-(\d\d)-(\d\d))?(\s(Draft|Final|Frameset|Transitional|Experimental))?(\s\d+)?//");
            var a = regex13.IsMatch(@"-//W3C//DTD HTML Experimental//");
           
            return "No Quirks";
        }
    }
}
