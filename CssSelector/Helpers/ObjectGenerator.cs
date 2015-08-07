using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;
using HtmlParser.Lexer;
using CssSelector.Objects;

namespace CssSelector
{
    public static class ObjectGenerator
    {
        static char[] Separators = new char[] { ' ', '+', '>', '~' };
        internal static State GenerateStateNexus(string selector, Action<string> triger)
        {
            int ind = 0;
            foreach (var item in selector)
            {
                if (ind!=0 && Separators.Contains(selector[ind]))
                {
                    break;
                }
                ind++;
            }
            if (ind == selector.Length || ind == 0)
            {
                return GenerateState(selector, triger);
            }
            else
            {
                string temp = selector.Substring(0, ind);
                var state = GenerateState(temp, triger);
                state.NextState = GenerateStateNexus(selector.Substring(ind, selector.Length - ind), triger);
                return state;
            }
        }
        private static State GenerateState(string selector, Action<string> triger)
        {
            HtmlTag tagName;
            var attribs = SelectorParser.ParseAttributes(selector);
            if (!Separators.Contains(selector[0]))
            {
                tagName = SelectorParser.ParseHtmlTag(selector);
                return new RootState(tagName, GenerateAttributes(attribs), triger);
            }
            tagName = SelectorParser.ParseHtmlTag(selector.Substring(1, selector.Length - 1));
            if (selector[0] == '>')
            {
                return new DirectChildState(tagName, GenerateAttributes(attribs), triger);
            }
            if (selector[0] == ' ')
            {
                return new ChildState(tagName, GenerateAttributes(attribs), triger);
            }
            if (selector[0] == '+')
            {
                return new ImmediatlyAfterState(tagName, GenerateAttributes(attribs), triger);
            }
            if (selector[0] == '~')
            {
                return new AfterState(tagName, GenerateAttributes(attribs), triger);
            }
            throw new ArgumentException("Some problem with selector you gived");
        }
        internal static Attribute ConvertToAttribute(HtmlToken token)
        {
            return new Attribute((int)token.GetAttribute(), String.Concat(token.Source.Skip(token.Value.StartIndex).Take(token.Value.Length)));
        }
        internal static string[] GenerateAttributes(IEnumerable<Attribute> attribs)
        {
            int max = 0;
            foreach (var s in Enum.GetValues(typeof(HtmlAttribute)))
            {
                max = max < (int)s ? (int)s : max;
            }
            string[] result = new string[max + 1];
            foreach (var item in attribs)
            {
                result[item.Id] = item.Value;
            }
            return result;
        }
    }
}
