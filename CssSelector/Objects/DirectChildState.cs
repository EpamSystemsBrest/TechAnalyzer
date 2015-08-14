using System;
using System.Collections.Generic;
using System.Linq;
using HtmlParser.Hash;
using HtmlParser.Lexer;

namespace CssSelector.Objects
{
    internal class DirectChildState : State
    {
        public DirectChildState(HtmlTag tag, string[] attribs, Action<string> triger)
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
                Level += 1;
                CurrentTag = token.GetTag();
            }
            if (token.TokenType == TokenType.CloseTag)
            {
                CurrentState = AttribCount;
                Level -= 1;
            }
            if (token.TokenType == TokenType.Attribute && Level == 2 && IsMatchTags(CurrentTag, TagName))
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
            if (Level == 0)
            {
                RemoveFromList(this);
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
            return new DirectChildState(TagName, Attributes, Triger) { NextState = this.NextState };
        }
    }
}
