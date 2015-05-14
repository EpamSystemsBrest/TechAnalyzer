using System;
using System.Linq;

namespace JsParser.Hash
{
    public class JsPunctuator
    {
        static readonly char[] SingleCharPunctuators = 
        {
            ' ', ',', '.', '(', ')', '[', ']', '{', '}', '/', '=', '+', '-', '*', '%', '&', '|', '^', '!', '~', '?', ':', '<', '>'
        };

        public static bool IsJsPunctuator(char c)
        {
            return SingleCharPunctuators.Contains(c);
        }
    }
}
