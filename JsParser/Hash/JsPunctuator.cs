using System;
using System.Linq;

namespace JsParser.Hash
{
    public static class JsPunctuator
    {
        static readonly char[] SingleCharPunctuators = 
        {
        };

        public static bool IsJsPunctuator(this char c)
        {
            return SingleCharPunctuators.Contains(c);
        }
    }
}
