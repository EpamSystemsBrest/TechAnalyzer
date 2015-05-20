using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using JsParser.Tests.Infrastructure;

namespace JsParser.Tests.Lexer
{
    public class JsLexerTest
    {
        [Fact]
        public void Parsing_Simple_Keyword()
        {
            "function".ShouldReturn("Keyword: function");
        }

        [Fact]
        public void Parsing_Simple_Identifier()
        {
            "myArray".ShouldReturn("Identifier: myArray");
        }

        [Fact]
        public void Parsing_Simple_IntNumeric()
        {
            "13.25".ShouldReturn("Numeric: 13.25");
        }

        [Fact]
        public void Parsing_Simple_BinNumeric()
        {
            "0b101001".ShouldReturn("Numeric: 0b101001");
        }

        [Fact]
        public void Parsing_Simple_OctNumeric()
        {
            "0o712".ShouldReturn("Numeric: 0o712");
        }

        [Fact]
        public void Parsing_Simple_HexNumeric()
        {
            "0x9FF".ShouldReturn("Numeric: 0x9FF");
        }
    }
}
