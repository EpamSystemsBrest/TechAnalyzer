﻿using System;
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
        #region Words

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
            "13".ShouldReturn("Numeric: 13");
        }

        [Fact]
        public void Parsing_Simple_FloatNumeric()
        {
            "444.44".ShouldReturn("Numeric: 444.44");
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

        [Fact]
        public void Parsing_Simple_String()
        {
            @"'one'".ShouldReturn("String: 'one'");
        }

        [Fact]
        public void Parsing_Simple_String1()
        {
            @"'utf-8'".ShouldReturn("String: 'utf-8'");
        }

        [Fact]
        public void Parsing_Simple_Bool()
        {
            "true".ShouldReturn("Boolean: true");
        }

        [Fact]
        public void Parsing_Simple_Null()
        {
            "null".ShouldReturn("Null: null");
        }

        #endregion Words

        #region Punctuators

        [Fact]
        public void Parsing_Simple_SingleCharPunctuator()
        {
            "[]".ShouldReturn("Punctuator: [", "Punctuator: ]");
        }

        [Fact]
        public void Parsing_Simple_Comment()
        {
            "[//Comment\n]".ShouldReturn("Punctuator: [", "Punctuator: ]");
        }

        [Fact]
        public void Parsing_Simple_MultilineComment()
        {
            "[/*one \n two */;".ShouldReturn("Punctuator: [", "Punctuator: ;");
        }

        [Fact]
        public void Parsing_Simple_BigMultilineComment()
        {
            @"[/* C-style comments can span
                as many lines as you like,
                as shown in this example */];".ShouldReturn("Punctuator: [", "Punctuator: ]", "Punctuator: ;");
        }


        [Fact]
        public void Parsing_Simple_4_char_punctuator()
        {
            ">>>=".ShouldReturn("Punctuator: >>>=");
        }

        [Fact]
        public void Parsing_Simple_3_char_punctuator()
        {
            "!==".ShouldReturn("Punctuator: !==");
        }

        [Fact]
        public void Parsing_Simple_2_char_punctuator()
        {
            "||".ShouldReturn("Punctuator: ||");
        }

        #endregion Punctuators

        #region General

        [Fact]
        public void Parsing_Simple_Code()
        {

            // Keyword
            // Punctuator
            // Identifier
            // Null
            // String
            // 
            @"var map = new google.maps.Map(document.getElementById('map-canvas',355), mapOptions);"
            .ShouldReturn(
                "Keyword: var", "Identifier: map", "Punctuator: =", "Keyword: new", "Identifier: google", "Punctuator: .",
                "Identifier: maps", "Punctuator: .", "Identifier: Map", "Punctuator: (", "Identifier: document", "Punctuator: .",
                "Identifier: getElementById", "Punctuator: (", "String: 'map-canvas'", "Punctuator: ,", "Numeric: 355", "Punctuator: )",
                "Punctuator: ,", "Identifier: mapOptions", "Punctuator: )", "Punctuator: ;"
            );
        }

        [Fact]
        public void Parsing_Simple_Addition_Code()
        {
            @"var a = 42;
            var b = 5;
            var c = a + b;"
            .ShouldReturn(
                "Keyword: var", "Identifier: a", "Punctuator: =", "Numeric: 42", "Punctuator: ;",
                "Keyword: var", "Identifier: b", "Punctuator: =", "Numeric: 5", "Punctuator: ;",
                "Keyword: var", "Identifier: c", "Punctuator: =", "Identifier: a", "Punctuator: +", "Identifier: b", "Punctuator: ;"
            );
        }

        #endregion General
    }
}
