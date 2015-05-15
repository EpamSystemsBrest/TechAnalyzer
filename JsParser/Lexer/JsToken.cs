using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsParser.Hash;
using ParserCommon;

namespace JsParser.Lexer
{
    public enum TokenType
    {
        Punctuator,
        Identifier,
        Keyword,
        String,
        Numeric,
        Boolean,
        Null,
        RegularExpression
    }

    public struct JsToken
    {
        public TokenType TokenType;
        private char[] Source;
        private StringSegment Value;
        private int Hash;

        public JsToken(TokenType tokenType, char[] source, StringSegment value)
        {
            TokenType = tokenType;
            Source = source;
            Value = value;
            Hash = -1;
        }

        public JsKeyword GetKeyword()
        {
            if (Hash >= 0) return (JsKeyword)Hash;
            Hash = (int) JsKeywordHash.GetKeyword(Source, Value.StartIndex, Value.Length);
            return (JsKeyword) Hash;
        }

        public override string ToString()
        {
            return Enum.GetName(TokenType.GetType(), TokenType);
        }
    }
}
