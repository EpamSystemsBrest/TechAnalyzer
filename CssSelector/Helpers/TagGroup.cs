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
        public IEnumerable<Tag> Tags;
        HtmlTag CurrentTag;
        bool IsBegin = true;

        public void GiveToken(HtmlToken token)
        {
            if(IsBegin)
            {
                foreach (var tag in Tags)
                {
                    tag.ResetAll();
                    IsBegin = false;
                }
            }

            if (token.TokenType == TokenType.OpenTag)
            {
                foreach (var tag in Tags.Where(w => IsMatch(w.TagName, CurrentTag)))
                {
                    tag.ResetAll();
                }
                CurrentTag = token.GetTag();
                return;
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
