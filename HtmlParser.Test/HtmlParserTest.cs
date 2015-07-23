using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Test.Infrastructure;
using Xunit;

namespace HtmlParser.Test
{
    public class HtmlParserTest
    {
        [Fact]
        public void No_HtmlEndPTag_1()
        {
            "<div><p></div>".ShouldBeFixedAs("<div><p></p></div>");
        }

        [Fact]
        public void No_HtmlEndPTag_2()
        {
            "<p><p>".ShouldBeFixedAs("<p></p><p>");
        }

        [Fact]
        public void No_HtmlEndPTag_And_HtmlEndLiTag()
        {
            "<p><ul><li><li></ul><p>".ShouldBeFixedAs("<p></p><ul><li></li><li></li></ul><p>");
        }

        [Fact]
        public void No_HtmlEndLiTag()
        {
            @"<ul class=""nav navbar-nav""><li>Hello</ul>".ShouldBeFixedAs(@"<ul class=""nav navbar-nav""><li>Hello</li></ul>");
        }

        [Fact]
        public void No_HtmlEndDivTag_1()
        {
            @"<template id=""tpl""><div id=""dv"">Div content</template>".ShouldBeFixedAs(@"<template id=""tpl""><div id=""dv"">Div content</div></template>");
        }

        [Fact]
        public void No_HtmlEndDivTag_2()
        {
            @"<template id=""tpl"">Template text<div id=""dv"">Div content</template>".ShouldBeFixedAs(@"<template id=""tpl"">Template text<div id=""dv"">Div content</div></template>");
        }

        [Fact]
        public void Wrong_HtmlEndSpanTag_NoHtmlEndDivTag()
        {
            @"<template id=""tpl""><div id=""dv"">Div content</span></template>".ShouldBeFixedAs(@"<template id=""tpl""><div id=""dv"">Div content</span></div></template>");
        }

        [Fact]
        public void Last_HtmlTemplateTag_ShouldBeIgnored()
        {
            @"<template id=""tmpl""></template></template>".ShouldBeFixedAs(@"<template id=""tmpl""></template></template>");
        }

        [Fact]
        public void No_HtmlEndTdTrTable_Tags()
        {
            @"<template id=""tpl""><table id=""tbl""><tr id=""tr""><td id=""td""></template>".ShouldBeFixedAs(@"<template id=""tpl""><table id=""tbl""><tbody><tr id=""tr""><td id=""td""></td></tr></tbody></table></template>");
        }

        [Fact]
        public void Implicit_HtmlTbodyTrTags_No_HtmlEndTdAndTableTags()
        {
            @"<table><td><td><table>".ShouldBeFixedAs(@"<table><tbody><tr><td></td><td></td></tr></tbody></table><table>");
        }


    }
}
