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
        public void Html_Paragraph_Test_1()
        {
            "<div><p></div>".ShouldBeFixedAs("<div><p></p></div>");
        }

        [Fact]
        public void Html_Paragraph_Test_2()
        {
            "<p><p>".ShouldBeFixedAs("<p></p><p>");
        }

        [Fact]
        public void Html_ParagraphAndList_Test()
        {
            "<p><ul><li><li></ul><p>".ShouldBeFixedAs("<p></p><ul><li></li><li></li></ul><p>");
        }

        [Fact]
        public void Html_List_Test()
        {
            @"<ul class=""nav navbar-nav""><li>Hello</ul>".ShouldBeFixedAs(@"<ul class=""nav navbar-nav""><li>Hello</li></ul>");
        }
    }
}
