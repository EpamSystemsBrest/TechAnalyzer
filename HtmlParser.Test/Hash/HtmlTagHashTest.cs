using HtmlParser.Hash;
using HtmlParser.Test.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HtmlParser.Test.Hash
{
    public class HtmlTagHashTest
    {
        string[] tagList = new string[320] {
       /* 0 */   null,          null,           "h6",           null,          null,            null,        
       /* 6 */   null,          "h5",           "del",          "head",        "label",         "legend",
      /* 12 */   "h4",          null,           "time",         "title",       null,            "h3",
      /* 18 */   "template",    "link",         "table",        "hgroup",      "picture",       "kbd",
      /* 24 */   null,          "embed",        null,           "th",          "datalist",      null, 
      /* 30 */   null,          "p",            "details",      null,          null,            "thead",
      /* 36 */   "select",      "h2",           "div",          "data",        "small",         "s",
      /* 42 */   "marquee",     "textarea",     "samp",         null,          "header",        "em",
      /* 48 */   "dir",         null,           null,           "a",           "listing",       "map",
      /* 54 */   "mark",        "param",        "dialog",       "dd",          "pre",           "meta",
      /* 60 */   "aside",       "applet",       "td",           null,          null,            null, 
      /* 66 */   "source",      "h1",           "menuitem",     "abbr",        "track",         null, 
      /* 72 */   "article",     null,           "menu",         "meter",       "figure",        "rp",
      /* 78 */   "var",         null,           null,           "u",           "hr",            "progress",
      /* 84 */   "base",        null,           "spacer",       "bgsound",     "fieldset",      null, 
      /* 90 */   "tbody",       null,           "tr",           null,          "area",          null, 
      /* 96 */   "keygen",      "address",      "basefont",     null,           null,           null, 
     /* 102 */   "section",     "xmp",          null,           null,           "script",       null, 
     /* 108 */   "sup",null,    null,           null,           "dl",           "nav",          "main",
     /* 114 */   "frame",       null,           "rb",           null,           "span",         null, 
     /* 120 */   "object",      "li",           "big",          "font",         null,           null, 
     /* 126 */   null,          "frameset",     null,           null,           null,           "acronym",
     /* 132 */   "noscript",    "cite",         null,           null,           null,           null,
     /* 138 */   "plaintext",   "video",        null,           null,           "noframes",     "form",
     /* 144 */   "tfoot",       null,           "ul",           "optgroup",     "html",         null, 
     /* 150 */   "b",           null,           null,           null,           "figcaption",   "footer",
     /* 156 */   "br",          null,           "nobr",         null,           "canvas",       "dt",
     /* 162 */   null,          null,           null,           null,           "tt",           "sub",
     /* 168 */   null,          "style",        "strike",       "summary",      "col",          "code",
     /* 174 */   null,          "center",       null,           null,           null,           null, 
     /* 180 */   "q",           null,           "img",          null,           null,           null, 
     /* 186 */   null,          "wbr",          "ruby",         "blockquote",   "output",       null,  
     /* 192 */   "colgroup",    "body",         null,           null,           "rt",           null,       
     /* 198 */   null,          "blink",        null,           null,           "dfn",          null, 
     /* 204 */   "audio",       "option",       null,           null,           null,           null, 
     /* 210 */   null,          "ol",           null,           null,           null,           "strong",
     /* 216 */   "caption",     null,           null,           null,           null,           null, 
     /* 222 */   null,          null,           "input",        "button",       "isindex",      "bdo",
     /* 228 */   null,          null,           null,           null,           "ins",          null, 
     /* 234 */   null,          null,           null,           null,           null,           null, 
     /* 240 */   "i",           null,           "bdi",          null,           null,           "iframe",
     /* 246 */   null,          null,           null,           null,           null,           null, 
     /* 252 */   null,          null,           null,           null,           null,           null, 
     /* 258 */   null,          null,           null,           null,           null,           null, 
     /* 264 */   null,          null,           null,           null,           null,           null, 
     /* 270 */   null,          null,           null,           null,           null,           null, 
     /* 276 */   null,          null,           null,           null,           null,           null, 
     /* 282 */   null,          null,           null,           null,           null,           null, 
     /* 288 */   null,          null,           null,           null,           null,           null, 
     /* 294 */   null,          null,           null,           null,           null,           null, 
     /* 300 */   null,          null,           null,           null,           null,           null, 
     /* 306 */   null,          null,           null,           null,           null,           null, 
     /* 312 */   null,          null,           null,           null,           null,           "rtc",
     /* 318 */   null
        };



        [Fact]
        public void GetTokenHash_Should_Resolve_Hash()
        {
            HtmlTestExtentions.TestHash(tagList, x => (int)HtmlTagHash.GetTag(x.ToArray(), 0, x.Length));
        }

        [Fact]
        public void GetTokenHash_Should_Resolve_Hash_For_UppercaseTags()
        {
            HtmlTestExtentions.TestHash(tagList, x => (int)HtmlTagHash.GetTag(x.ToUpper().ToArray(), 0, x.Length));
        }

        [Fact]
        public void GetTokenHash_Should_Work_With_Actual_ArraySegment()
        {
            var actual = HtmlTagHash.GetTag("prefix title suffix".ToArray(), 7, 5);
            Assert.Equal(HtmlTag.Title, actual);
        }


        //[TestMethod]
        //public void GenerateEnumForTags() {
        //    for (int i = 0; i < tagList.Length; i++) {
        //        if (tagList[i] != null) {
        //            Debug.WriteLine("       {0} = {1},", new string(tagList[i].Take(1).Select(x => char.ToUpper(x)).Concat(tagList[i].Skip(1).Where(x => x != '-')).ToArray()), i);
        //        }
        //    }
        //}
    }
}
