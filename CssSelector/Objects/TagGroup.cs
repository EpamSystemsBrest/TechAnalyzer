using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;
using HtmlParser.Lexer;

namespace CssSelector
{
    internal class TagGroup
    {
        IDictionary<HtmlTag, Tag> Tags;
        HtmlTag CurrentTag;
        bool ContainCustom = false;

        public TagGroup(IDictionary<HtmlTag, Tag> tags)
        {
            Tags = tags;
            foreach (var tag in Tags)
            {
                tag.Value.ResetAll();
            }
            if (Tags.ContainsKey(HtmlTag.Custom))
            {
                ContainCustom = true;
            }
        }
        public void GiveToken(HtmlToken token)
        {
            if (token.TokenType == TokenType.OpenTag)
            {
                if (ContainCustom)
                {
                    Tags[HtmlTag.Custom].ResetAll();
                }
                var temp = token.GetTag();
                if (!Tags.ContainsKey(temp))
                {
                    return;
                }
                CurrentTag = temp;
                Tags[CurrentTag].ResetAll();
                return;
            }
            if (token.TokenType == TokenType.Attribute)
            {
                if (!(CurrentTag == HtmlTag.Custom && !ContainCustom))
                {
                    Tags[CurrentTag].ChangeState(ObjectGenerator.ConvertToAttribute(token));
                }
                if (ContainCustom)
                {
                    Tags[HtmlTag.Custom].ChangeState(ObjectGenerator.ConvertToAttribute(token));
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
