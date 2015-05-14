using System;
using ParserCommon;

namespace JsParser.Hash
{
    public class JsKeyWordHash
    {
        static byte[] associationValues = new byte[] {
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 30, 40, 15,
               5,  0, 10,  5,  5,  5, 79, 79, 15, 60,
               0, 20, 15, 79, 10,  0, 35,  0, 40, 50,
              55, 25, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79, 79, 79, 79, 79,
              79, 79, 79, 79, 79, 79
        };

        static readonly string[] wordlist =
        {
            "", "", "","new","enum","super","","in","int","","short","delete","default","debugger",
            "interface","instanceof","return","if","function","else","final","public","finally",
            "","char","", "","do","","goto","float","double","private","for","protected","class",
            "native","synchronized","","long","const","static","","continue","this","throw","throws",
            "","try","case","catch","","package","","transient","break","switch","", "","with","while",
            "export","extends","","void","","typeof","boolean","volatile","byte","","import","","var",
            "","implements","", "","abstract"
        };

        public static JsKeyWord Hash(char[] content, int offset, int length)
        {
            int hash = length + associationValues[content[offset + 1]] + associationValues[content[offset]];

            return (JsKeyWord)hash;
        }        

        const int TOTAL_KEYWORDS = 56;
        const int MIN_WORD_LENGTH = 2;
        const int MAX_WORD_LENGTH = 12;
        const int MIN_HASH_VALUE = 3;
        const int MAX_HASH_VALUE = 78;        

        public static bool IsJSKeyWord(char[] content, int offset, int length)
        {
            if (length <= MAX_WORD_LENGTH && length >= MIN_WORD_LENGTH)
            {
                int key = (int)Hash(content, offset, length);

                if (key <= MAX_HASH_VALUE && key >= 0) // >= MIN_HASH_VALUE ???
                {
                    string s = wordlist[key];

                    if (new StringSegment(offset, length).ToString(content) == s)
                        return true;
                }
            }
            return false;
        }
    }
}
