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
        public JsKeyword TokenType;
        private char[] Source;
        private StringSegment Value;
        private int Hash;

        public JsToken(JsKeyword tokenType, char[] source, StringSegment value)
        {
            TokenType = tokenType;
            Source = source;
            Value = value;
            Hash = -1;
        }

        public JsKeyword GetKeyword()
        {
            return JsKeywordHash.Hash(Source, Value.StartIndex, Value.Length);
        }
    }


}
