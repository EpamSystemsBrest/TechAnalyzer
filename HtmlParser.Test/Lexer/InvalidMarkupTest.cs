﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Test.Infrastructure;
using Xunit;

namespace HtmlParser.Test.Lexer
{
   
    public class InvalidMarkupTest
    {

        [Fact]
        public void DoubleQuote_After_Attribute_Value_Should_Not_Throw_An_Error()
        {
            @"<a style=""font-weight:normal;"""">Link Title</a>"
            .ShouldReturn(
                @"Tag: <a>",
                @"Attr: style=""font-weight:normal;""",
                @"Text: ""Link Title""",
                @"Tag: </a>"
            );
        }


        [Fact]
        public void Semicolon_After_Attribute_Value_Should_Not_Throw_An_Error()
        {
            @"<a style=""font-weight:normal;"";>Link Title</a>"
            .ShouldReturn(
                @"Tag: <a>",
                @"Attr: style=""font-weight:normal;""",
                @"Text: ""Link Title""",
                @"Tag: </a>"
            );
        }

        [Fact]
        public void Unescaped_Quotes_In_Attribute_Value_Should_Not_Throw_An_Error()
        {
            @"<href title="" Some Text "" Some Other Text "" href=""page.html"">"
            .ShouldReturn(
                @"Tag: <href>",
                @"Attr: title="" Some Text """,
                @"Attr: some=""""",
                @"Attr: other=""""",
                @"Attr: text=""""",
                @"Attr: href=""page.html"""
            );
        }
    }
}
