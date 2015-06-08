using System;

namespace HtmlParser.Hash
{
    public class HtmlTagHash
    {

        static readonly short[] associationValues = new short[] {
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319,  60,
            30,  15,  5,   5,   0,   5,   0,   0,   319, 319,
            319, 319, 319, 319, 319, 25,  75,  130, 5,   0,
            70,  45,  0,   120, 0,   15,   0,  30,  75,  105,
            15,  90,  40,  20,  10,  40,  30,  145, 70,  75,
            319, 319, 319, 319, 319, 319, 319, 25,  75,  130,
            5,   0,   70,  45,  0,   120, 0,   15,  0,   30,
            75,  105, 15,  90,  40,  20,  10,  40,  30,  145,
            70,  75,  319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            319, 319, 319, 319, 319, 319, 319, 319, 319
    };


        public static HtmlTag GetTag(char[] content, int offset, int length)
        {
            int hval = length;
            if (hval != 1)
            {
                hval += associationValues[content[1 + offset] + 3];
            }
            hval += associationValues[content[offset]] + associationValues[content[length - 1 + offset]];
            string result = ((HtmlTag)hval).ToString();

            if (result.Length != length) return HtmlTag.Custom;
            for (int i = 0; i < length; i++)
            {
                int val1 = content[i + offset] > 96 ? content[i + offset] - 32 : content[i + offset];
                int val2 = result[i] > 96 ? result[i] - 32 : result[i];
                if (val1 != val2) return HtmlTag.Custom;
            }
            return (HtmlTag)hval;
        }
    }


}

