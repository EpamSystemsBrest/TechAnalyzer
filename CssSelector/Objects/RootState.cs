using System;
using System.Collections.Generic;
using System.Linq;
using HtmlParser.Hash;
using HtmlParser.Lexer;

namespace CssSelector.Objects
{
    internal class RootState : State
    {
        public RootState(HtmlTag tag, string[] attribs, Action<string> triger)
        {
            TagName = tag;
            Attributes = attribs;
            Triger = triger;
            AttribCount = Attributes.Count(w => !string.IsNullOrEmpty(w));
            CurrentState = AttribCount;
            RemoveFromList = Selector.RemoveFromList;
            AddToList = Selector.AddToList;
        }
        public override void ChangeState(HtmlToken token)
        {
            if (token.TokenType == TokenType.OpenTag)
            {
                CurrentState = AttribCount;
                CurrentTag = token.GetTag();
            }
            if (token.TokenType == TokenType.CloseTag)
            {
                CurrentState = AttribCount;
            }
            if (token.TokenType == TokenType.Attribute && IsMatchTags(CurrentTag, TagName))
            {
                var attribute = ObjectGenerator.ConvertToAttribute(token);
                if (attribute.Id >= Attributes.Length) return;
                if (string.IsNullOrEmpty(Attributes[attribute.Id])) return;

                if (Attributes[attribute.Id] == attribute.Value)
                {
                    CurrentState -= 1;
                }
                if (Attributes[attribute.Id] == "$result")
                {
                    CurrentState -= 1;
                    NeededValue = attribute.Value;
                }
            }
            if (CurrentState == 0 && IsMatchTags(CurrentTag, TagName))
            {
                if (NextState != null)
                {
                    AddToList(NextState);
                }
                else
                {
                    Triger(NeededValue);
                }
                CurrentTag = HtmlTag.Custom;
            }
        }
        public override State GetCopy()
        {
            return new RootState(TagName, Attributes, Triger) {NextState = NextState };
        }
    }
}
