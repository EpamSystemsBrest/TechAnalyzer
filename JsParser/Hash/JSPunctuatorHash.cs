using System;
using ParserCommon;

namespace JsParser.Hash
{
    public class JSPunctuatorHash
    {
        static byte[] associationValues = new byte[] {
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 45, 50, 31, 97, 97, 45, 45, 40,
              25, 55, 20, 35, 30, 10, 20, 50, 26, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 25, 20,
              22,  5,  0, 15, 10, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 10, 10,  0, 35, 36, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97,  0, 10, 50,  0,  0, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97, 97, 97, 97,
              97, 97, 97, 97, 97, 97, 97 
        };

        static readonly string[] wordlist =
        {
            "","~","=>","", "", "","=","==","===","", "","{","<=","<<=","", "",">",">>",
            ">>>","", "","[",">=",">>=",">>>=","","?","-=","<","<<","","-","--","/=",
            "", "","]","+=","!=","!==","",",","*=","^=","", "",":","&=","", "", "","}",
            "%=","", "", "","*","|=","", "", "","|","||","", "", "","+","++","", "", "",
            ".","^","", "", "",")","/","", "", "","(","!","", "", "","&","&&","", "", "",
            "%","", "", "", ""," " 
        };

        public static int Hash(char[] content, int offset, int length)
        {
            int hash = length + associationValues[content[offset + length - 1]] + associationValues[content[offset] + 1];

            return hash;
        }

        const int TOTAL_KEYWORDS = 49;
        const int MIN_WORD_LENGTH = 1;
        const int MAX_WORD_LENGTH = 4;
        const int MIN_HASH_VALUE = 1;
        const int MAX_HASH_VALUE = 96;

        public static bool IsJSPunctuator(char[] content, int offset, int length)
        {
            if (length <= MAX_WORD_LENGTH && length >= MIN_WORD_LENGTH)
            {
                int key = Hash(content, offset, length);

                if (key <= MAX_HASH_VALUE && key >= 0)
                {
                    string s = wordlist[key];

                    if (new StringSegment(offset, length).ToString(content) == s)
                        return true;
                }
            }
            return false;
        }

        //public static bool IsJSPunctuator(char[] content, int offset, int length)
        //{
        //    return wordlist
        //}
    }
}
