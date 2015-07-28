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
        private IEnumerable<State> States;
        public void TokenSelector(IEnumerable<HtmlToken> tokens, IEnumerable<Tuple<string, Action<string>>> selectors)
        {
            States = selectors.Select(w => SelectorParser.GenerateState(w.Item1, w.Item2)).ToArray();
            Element temp = new Element();
            var attribs = new List<Attribute>();
            foreach (var item in tokens)
            {
                if (item.TokenType == TokenType.Attribute)
                {
                    attribs.Add(new Attribute(item.GetAttribute(), String.Concat(item.Source.Skip(item.Value.StartIndex).Take(item.Value.Length))));
                }
                if (item.TokenType == TokenType.OpenTag || item.TokenType == TokenType.CloseTag)
                {
                    if (item.TokenType == TokenType.OpenTag)
                    {
                        temp.Name = item.GetTag();
                    }
                    temp.Attributes = attribs;
                    foreach (var state in States)
                    {
                        state.ChangeState(temp);
                    }
                    attribs.Clear();
                }
            }
        }
    }
}