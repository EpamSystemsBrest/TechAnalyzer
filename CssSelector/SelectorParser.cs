using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;

namespace CssSelector
{
    internal static class SelectorParser
    {
        public static HtmlTag ParseHtmlTag(string selector)
        {
            int index = selector.IndexOf('[');
            if (index == 0) return HtmlTag.Custom;
            string temp = ToUpperFirstChar(selector.Substring(0, index));
            return (HtmlTag)Enum.Parse(typeof(HtmlTag), temp);
        }
        public static string ParseAttributeValue(string selector)
        {
            return selector.Substring(selector.IndexOf('=') + 1, selector.Length - selector.IndexOf('=') - 2);
        }
        public static HtmlAttribute ParseAttributeName(string selector)
        {
            string tempName = selector.Substring(1, selector.IndexOf('=') - 1);
            return (HtmlAttribute)Enum.Parse(typeof(HtmlAttribute), SelectorParser.ToUpperFirstChar(tempName));
        }
        public static IEnumerable<Attribute> ParseAttributes(string selector)
        {
            int index = selector.IndexOf('[');
            selector = selector.Substring(index, selector.Length - index);
            int i1 = 0;
            int temp;
            string str;
            for (int i = 0; i < selector.Length; i++)
            {
                if (selector[i] == '[' || i == selector.Length - 1)
                {
                    temp = i == selector.Length - 1 ? i + 1 : i;
                    str = selector.Substring(i1, temp - i1);
                    if (!string.IsNullOrEmpty(str))
                    {
                        yield return new Attribute(selector.Substring(i1, temp - i1));
                    }
                    i1 = i;
                }
            }
        }
        public static State GenerateState(string selector, Action<string> action)
        {
            var attribs = SelectorParser.ParseAttributes(selector);
            var neededName = attribs.Any(w => w.Value == "$result") ? attribs.First(w => w.Value == "$result").Name : 0;
            return new State()
            {
                Attributes = attribs,
                Name = SelectorParser.ParseHtmlTag(selector),
                Trigger = action,
                TestedState = attribs.Count(),
                NeededName = neededName
            };
            
        }

        private static string ToUpperFirstChar(string str)
        {
            if (str[0] < 97 && str[0] > 122) return str;
            return (char)(str[0] - 32) + str.Substring(1, str.Length - 1);
        }
    }
}
