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
        string[] tagList = new string[201] {
      /*   0 */     null,       null,       null,       null,         null, 
      /*   5 */     null,       null,       null,       null,         null, 
      /*  10 */     null,       null,       null,       null,         null,
      /*  15 */     "noscript", "s",        null,       null,         null,       
      /*  20 */     null,       "script",   "strike",   "u",          "marquee",  
      /*  25 */     "basefont", "base",     "output",   "body",       "tt",
      /*  30 */     "summary",  "h6",       "noframes", "address",    "strong",
      /*  35 */     "article",  "h5",       "style",    "option",     "th",
      /*  40 */     "h4",       "title",    "button",   "blockquote", "optgroup",
      /*  45 */     "samp",     "time",     "hgroup",   "big",        "ol",
      /*  50 */     "ul",       "tfoot",    "dt",       "tbody",      "ins",
      /*  55 */     "iframe",   "video",    "br",       "hr",         "figure",
      /*  60 */     "menu",     "var",      "meter",    "datalist",   "audio",
      /*  65 */     "listing",  "tr",       "details",  "wbr",        "figcaption",
      /*  70 */     "html",     "aside",    "main",     "img",        "h3",
      /*  75 */     "h2",       "b",        "bdo",      "object",     "select",
      /*  80 */     "mark",     "code",     "h1",       "font",       "span",
      /*  85 */     "dl",       "cite",     "fieldset", "bgsound",    null,
      /*  90 */     "source",   "section",  "td",       null,         "acronym",
      /*  95 */     "rt",       null,       null,       "dir",        "p",
      /* 100 */     "table",    null,       "footer",   "dfn",        "frameset",
      /* 105 */     "frame",    "small",    "nav",      "progress",   "i",
      /* 110 */     "spacer",   "li",       "rp",       null,         "form",
      /* 115 */     "dd",       "menuitem", "nobr",     "canvas",     "header",
      /* 120 */     "applet",   "a",        "q",        "meta",       "blink",
      /* 125 */     "legend",   "sup",      "pre",      "map",        "em",
      /* 130 */     "abbr",     "bdi",      "xmp",      null,         "textarea",
      /* 135 */     null,       "thead",    "keygen",   "sub",        null, 
      /* 140 */     null,       null,       "input",    "plaintext",  "link",
      /* 145 */     "head",     null,       "track",    null,         "div",
      /* 150 */     "label",    "center",   "del",      "param",      null, 
      /* 155 */     null,       null,       null,       "colgroup",   null, 
      /* 160 */     null,       "data",     null,       null,         null,
      /* 165 */     "area",     null,       "ruby",     null,         null, 
      /* 170 */     null,       "kbd",      null,       null,         "col",
      /* 175 */     null,       null,       "isindex",  null,         null, 
      /* 180 */     null,       null,       "caption",  null,         null, 
      /* 185 */     null,       null,       null,       null,         null, 
      /* 190 */     null,       null,       null,       null,         null, 
      /* 195 */     null,       null,       null,       null,         null,
      /* 200 */     "embed"
        };

        string[] tagList2 = new string[235] {
         /*   0 */           null,           "b",             null,           null,           null,       
         /*   5 */           null,           null,            "br",           null,           null,       
         /*  10 */           "blink",        "s",             null,           null,           "span",    
         /*  15 */           "blockquote",   "script",        null,           "frameset",     null, 
         /*  20 */           "frame",        "spacer",        null,           "fieldset",     null,     
         /*  25 */           "figcaption",   "figure",        "tr",           "big",          null, 
         /*  30 */           "track",        "select",        "section",       null,          "time",
         /*  35 */           "title",        null,            "h6",           "basefont",     "base", 
         /*  40 */           "style",        "strike",        "hr",           "dir",          "font", 
         /*  45 */           null,           "source",        "tt",           null,           "samp", 
         /*  50 */           null,           "footer",        "dl",           "template",     "link",         
         /*  55 */           null,           "strong",        "dt",           "pre",          "plaintext",    
         /*  60 */           "table",        "dialog",        "h5",           "div",          "cite", 
         /*  65 */           "meter",        "header",        "picture",      "datalist",     "main", 
         /*  70 */           "small",        "button",        "listing",      "del",          "mark", 
         /*  75 */           null,           null,            "marquee",      "map",          "menu", 
         /*  80 */           "input",        "center",        "h4",           "sup",          "html", 
         /*  85 */           null,           null,            "caption",      "bdo",          "code",
         /*  90 */           null,           "subandsup",     "details",      "progress",     "body", 
         /*  95 */           "label",        "option",        "ul",           "colgroup",     "form", 
         /* 100 */           "thead",        "p",             "isindex",      "col",          null, 
         /* 105 */           null,           null,            "ol",           "optgroup",     "head", 
         /* 110 */           null,           "applet",        "article",      "ins",          null, 
         /* 115 */           null,           "legend",        "td",           "menuitem",     null, 
         /* 120 */           null,           "canvas",        "rp",           "textarea",     null, 
         /* 125 */           "tfoot",        "keygen",        "dd",           "img",          null, 
         /* 130 */           "aside",        "i",             "rt",           "dfn",          "meta", 
         /* 135 */           "tbody",        null,            "summary",      "sub",          "data", 
         /* 140 */           "param",        "object",        "li",           "bdi",          null, 
         /* 145 */           null,           "hgroup",        "th",           "noscript",     "nobr", 
         /* 150 */           null,           "u",             "bgsound",      "var",          null, 
         /* 155 */           "embed",        "output",        "em",           "xmp",          "abbr", 
         /* 160 */           null,           "q",             "h3",           "rtc",          null, 
         /* 165 */           "video",        null,            "acronym",      "nav",          null, 
         /* 170 */           null,           null,            "h2",           "wbr",          null, 
         /* 175 */           null,           "iframe",        "h1",           null,           "area", 
         /* 180 */           null,           null,            null,           "noframes",     null, 
         /* 185 */           null,           null,            "address",      null,           null, 
         /* 190 */           null,           null,            null,           null,           null, 
         /* 195 */           null,           null,            null,           null,           null, 
         /* 200 */           null,           "a",             null,           "kbd",          null, 
         /* 205 */           null,           null,            null,           null,           null, 
         /* 210 */           "audio",        null,            null,           null,           null, 
         /* 215 */           null,           null,            null,           null,           null, 
         /* 220 */           null,           null,            "rb",           null,           null, 
         /* 225 */           null,           null,            null,           null,           null, 
         /* 230 */           null,           null,            null,           null,          "ruby"
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
