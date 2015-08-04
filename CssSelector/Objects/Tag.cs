using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;
using HtmlParser.Lexer;

namespace CssSelector
{
    public class Tag
    {
        public HtmlTag TagName;
        public IEnumerable<HtmlAttributeGroup> AttributesGroups;

        public void ResetAll()
        {
            foreach (var group in AttributesGroups.Where(w=>w.Count==0 || w.Count != w.CurrentState))
            {
                group.Reset();
            }
        }
        public Tag(HtmlTag name, IEnumerable<HtmlAttributeGroup> groups)
        {
            TagName = name;
            AttributesGroups = groups;
        }
        public Tag() { }
        public void ChangeState(Attribute attribute)
        {
            foreach (var group in AttributesGroups.Where(w=>w.CurrentState!=0))
            {
                group.GiveAttribute(attribute);
            }
        }
        public virtual void CheckForTag(HtmlToken token) { }
    }


    public class ChildTag : Tag
    {
        public Tag NextTag;
        public ChildTag(HtmlTag name, IEnumerable<HtmlAttributeGroup> groups)
        {
            TagName = name;
            AttributesGroups = groups;
        }
        public int TagCounter = 1;
        public override void CheckForTag(HtmlToken token)
        {
            if (token.GetTag() == Father)
            {
                if (token.TokenType == TokenType.OpenTag)
                {
                    TagCounter += 1;
                }
                if(token.TokenType == TokenType.CloseTag)
                {
                    TagCounter -= 1;
                }
            }
            if (TagCounter == 0)
            {
                RemoveThisFromList(this);
            }
        }
    }
}
