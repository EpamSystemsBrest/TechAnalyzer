using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;
using HtmlParser.Lexer;

namespace CssSelector.Objects
{
    public class State
    {
        public HtmlTag TagName;
        public string[] Attributes;
        public State NextState;
        public Action<string> Triger;
        public int CurrentState;
        public int AttribCount;
        public string NeededValue;

        public virtual void ChangeState(HtmlToken token)
        {
            if(token.TokenType == TokenType.OpenTag)
            {
                CurrentState = AttribCount;
            }
            if(token.TokenType == TokenType.CloseTag)
            {
                CurrentState = AttribCount;
            }
            if(token.TokenType == TokenType.Attribute)
            {
                var attribute = new Attribute();
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
                if (CurrentState == 0)
                {
                    Triger(NeededValue);
                }
            }
        }
    }

    public class ChildState: State
    {
        public int Level = 1;
        public Action<State> RemoveFromList;

        public override void ChangeState(HtmlToken token)
        {
            if (token.TokenType == TokenType.OpenTag)
            {
                CurrentState = AttribCount;
                Level += 1;
            }
            if (token.TokenType == TokenType.CloseTag)
            {
                CurrentState = AttribCount;
                Level -= 1;
            }
            if (token.TokenType == TokenType.Attribute)
            {
                var attribute = new Attribute();
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
                if (CurrentState == 0)
                {
                    Triger(NeededValue);
                }
            }
            if(Level == 0)
            {
                RemoveFromList(this);
            }
        }
    }

    public class DirectChildState : State
    {
        public int Level = 1;
        public Action<State> RemoveFromList;

        public override void ChangeState(HtmlToken token)
        {
            if (token.TokenType == TokenType.OpenTag)
            {
                CurrentState = AttribCount;
                Level += 1;
            }
            if (token.TokenType == TokenType.CloseTag)
            {
                CurrentState = AttribCount;
                Level -= 1;
            }
            if (token.TokenType == TokenType.Attribute && Level % 2 == 1)
            {
                var attribute = new Attribute();
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
                if (CurrentState == 0)
                {
                    Triger(NeededValue);
                }
            }
            if (Level == 0)
            {
                RemoveFromList(this);
            }
        }
    }
}
