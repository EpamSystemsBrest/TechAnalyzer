using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;
using HtmlParser.Lexer;

namespace CssSelector
{
    public class TagGroup
    {
        public Tag[] Tags;
        HtmlTag CurrentTag;

        public void GiveToken(HtmlToken token)
        {
            if (token.TokenType == TokenType.OpenTag)
            {
                CurrentTag = token.GetTag();
                foreach (var tag in Tags)
                {
                    tag.ResetAll();
                }
            }
            if (token.TokenType == TokenType.Attribute)
            {
                foreach (var tag in Tags.Where(w=>IsMatch(w.TagName, CurrentTag)))
                {
                    tag.ChangeState(SelectorParser.ConvertToAttribute(token));
                }
            }
        }

        private bool IsMatch(HtmlTag template, HtmlTag current)
        {
            if (template == HtmlTag.Custom) return true;
            return template == current;
        }
    }
}
