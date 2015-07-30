using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using HtmlParser.Lexer;
using ParserCommon;
using HtmlParser.Hash;

namespace CssSelector
{
    public class Selector
    {
        TagGroup Tags;

        public  void TokenSelector(IEnumerable<HtmlToken> tokens, IEnumerable<Tuple<string, Action<string>>> selectors)
        {
            Tags = ObjectGenerator.GenerateTagGroup(selectors);
            foreach (var item in tokens)
            {
                Tags.GiveToken(item);
            }
        }
    }
}