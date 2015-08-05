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

        public static State GenerateStateNexus(string selector, Action<string> triger)
        {
            char[] separstors = new char[] { ' ', '+', '>', '~' };
            int ind = 0;
            foreach (var item in selector)
            {
                if (ind!=0 && separstors.Contains(selector[ind]))
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
                temp = selector.Substring(ind, selector.Length - ind);
                state.NextState = GenerateStateNexus(temp, triger);
                return state;
            }
        }


        public static StateGroup GenerateStateGroup(IEnumerable<Tuple<string, Action<string>>> selectors)
        {
            var statelines = selectors.Select(w => GenerateStateNexus(w.Item1, w.Item2)).ToArray();
            return new StateGroup(statelines);
        }

        public static State GenerateState(string selector, Action<string> triger)
        {
            char[] separators = new char[] { '>', ' ', '+', '~' };
            HtmlTag tagName;
            var attribs = SelectorParser.ParseAttributes(selector);
            if (!separators.Contains(selector[0]))
            {
                tagName = SelectorParser.ParseHtmlTag(selector);
                return new RootState(tagName, attribs, triger);
            }

            tagName = SelectorParser.ParseHtmlTag(selector.Substring(1, selector.Length - 1));
            if (selector[0] == '>')
            {
                return new DirectChildState(tagName, attribs, triger);
            }
            if (selector[0] == ' ')
            {
                return new ChildState(tagName, attribs, triger);
            }
            if (selector[0] == '+')
            {
                return new ImmediatlyAfterState(tagName, attribs, triger);
            }
            if (selector[0] == '~')
            {
                return new AfterState(tagName, attribs, triger);
            }
            throw new ArgumentException();
        }
        public static Attribute ConvertToAttribute(HtmlToken token)
        {
            return new Attribute((int)token.GetAttribute(), String.Concat(token.Source.Skip(token.Value.StartIndex).Take(token.Value.Length)));
        }
        public static string[] GenerateAttributes(IEnumerable<Attribute> attribs)
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
        public static TagGroup GenerateTagGroup(IEnumerable<Tuple<string, Action<string>>> selectors)
        {
            var tags = selectors.Select(w => new { Name = SelectorParser.ParseHtmlTag(w.Item1), Attributes = SelectorParser.ParseAttributes(w.Item1), Triger = w.Item2 })
                                .GroupBy(w => w.Name)
                                .Select(w => new Tag(w.Key, w.Select(x => new HtmlAttributeGroup(GenerateAttributes(x.Attributes), x.Triger))
                                                             .ToArray()))
                                .ToDictionary(w => w.TagName);
            return new TagGroup(tags);
        }
    }
}
