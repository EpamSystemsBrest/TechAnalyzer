using System;
using System.Linq;

namespace JsParser.Hash
{
    public static class JsPunctuator
    {
        static readonly char[] Punctuators = 
        {
           '\0', '\r', '\t', '\n', ' ', ',', '.', '(', ')', '[', ']', '{', '}', '/', '=', '+', '-', '*', '%', '&', '|', '^', '!', '~', '?', ':', ';', '<', '>'
        };

        static readonly char[] SingleCharPunctuators =
        {
            '(', ')', '[', ']', '{', '}', '~', '?', ':', ';', ','
        };

        static readonly string[] DoubleCharPunctuators =
        {
            "&&", "||", "==", "!=", "+=", "-=", "*=", "/=", "++", "--", "<<", ">>", "&=", "|=", "^=", "%=", "<=", ">=", "=>"
        };

        static readonly string[] ThreeCharPunctuators =
        {
            "...", "===", "!==", ">>>", "<<=", ">>="
        };

        public static bool IsPunctuator(this char c)
        {
            return Punctuators.Contains(c);
        }

        public static bool IsSingleCharPunctuator(this char c)
        {
            return SingleCharPunctuators.Contains(c);
        }

        public static bool IsDot(this char c)
        {
            return c == '.';
        }

        public static bool IsScreening(this char c)
        {
            return c == '\'' || c == '\"';
        }

        public static bool IsDoubleCharPunctuator(this string c)
        {
            return DoubleCharPunctuators.Contains(c);
        }

        public static bool IsThreeCharPunctuator(this string c)
        {
            return ThreeCharPunctuators.Contains(c);
        }
    }
}
