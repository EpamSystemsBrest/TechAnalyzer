using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;
using HtmlParser.Lexer;

namespace CssSelector
{
    public static class ObjectGenerator
    {
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
