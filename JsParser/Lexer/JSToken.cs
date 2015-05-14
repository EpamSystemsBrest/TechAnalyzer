using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsParser.Hash;
using ParserCommon;

namespace JsParser.Lexer
{
    public struct JsToken
    {
        public JsKeyWord TokenType;
        private char[] Source;
        private StringSegment Value;
        private int Hash;

        public JsToken(JsKeyWord tokenType, char[] source, StringSegment value)
        {
            TokenType = tokenType;
            Source = source;
            Value = value;
            Hash = -1;
        }

        public JsKeyWord GetKeyword()
        {
            return JsKeyWordHash.Hash(Source, Value.StartIndex, Value.Length);
        }
    }

    
}
