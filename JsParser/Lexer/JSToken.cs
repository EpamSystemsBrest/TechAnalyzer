using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsParser.Hash;
using ParserCommon;

namespace JsParser.Lexer
{
    public struct JSToken
    {
        public JSKeyWord TokenType;
        private char[] Source;
        public StringSegment value;
    }
}
