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
        public Action<State> AddToList;
        public Action<State> RemoveFromList;
        public int CurrentState;
        public int AttribCount;
        public string NeededValue;
        public HtmlTag CurrentTag;

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
        public bool IsMatchTags(HtmlTag current, HtmlTag needed)
        {
            if (needed == HtmlTag.Custom) return true;
            return current == needed;
        }
    }

    public class RootState : State
    {
        public RootState(HtmlTag tag, IEnumerable<Attribute> attribs, Action<string> triger)
        {
            TagName = tag;
            Attributes = ObjectGenerator.GenerateAttributes(attribs);
            Triger = triger;
            AttribCount = Attributes.Count(w => !string.IsNullOrEmpty(w));
            CurrentState = AttribCount;
            RemoveFromList = StateGroup.RemoveFromList;
            AddToList = StateGroup.AddToList;
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
                    if (NextState != null)
                    {
                        AddToList(NextState);
                    }
                    else
                    {
                        Triger(NeededValue);
                    }
                }
            }
        }
    }

    public class ChildState: State
    {
        public int Level = 1;
        public ChildState(HtmlTag tag, IEnumerable<Attribute> attribs, Action<string> triger)
        {
            TagName = tag;
            Attributes = ObjectGenerator.GenerateAttributes(attribs);
            Triger = triger;
            AttribCount = Attributes.Count(w=>!string.IsNullOrEmpty(w));
            CurrentState = AttribCount;
            RemoveFromList = StateGroup.RemoveFromList;
            AddToList = StateGroup.AddToList;
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
            if (token.TokenType == TokenType.Attribute && IsMatchTags(CurrentTag, TagName))
            {
                var attribute = ObjectGenerator.ConvertToAttribute(token);

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
                    if (NextState != null)
                    {
                        AddToList(NextState);
                    }else
                    {
                        Triger(NeededValue);
                    }
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
        public DirectChildState(HtmlTag tag, IEnumerable<Attribute> attribs, Action<string> triger)
        {
            TagName = tag;
            Attributes = ObjectGenerator.GenerateAttributes(attribs);
            Triger = triger;
            AttribCount = Attributes.Count(w => !string.IsNullOrEmpty(w));
            CurrentState = AttribCount;
            RemoveFromList = StateGroup.RemoveFromList;
            AddToList = StateGroup.AddToList;
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
                    if (NextState != null)
                    {
                        AddToList(NextState);
                    }
                    else
                    {
                        Triger(NeededValue);
                    }
                }
            }
            if (Level == 0)
            {
                RemoveFromList(this);
            }
        }
    }

    public class AfterState : State
    {
        public int Level = 1;
        public AfterState(HtmlTag tag, IEnumerable<Attribute> attribs, Action<string> triger)
        {
            TagName = tag;
            Attributes = ObjectGenerator.GenerateAttributes(attribs);
            Triger = triger;
            AttribCount = Attributes.Count(w => !string.IsNullOrEmpty(w));
            CurrentState = AttribCount;
            RemoveFromList = StateGroup.RemoveFromList;
            AddToList = StateGroup.AddToList;
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
            if (token.TokenType == TokenType.Attribute && Level == 1 && IsMatchTags(CurrentTag, TagName))
            {
                var attribute = ObjectGenerator.ConvertToAttribute(token);

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
                    if (NextState != null)
                    {
                        AddToList(NextState);
                    }
                    else
                    {
                        Triger(NeededValue);
                    }
                }
            }
            if (Level == -1)
            {
                RemoveFromList(this);
            }
        }
    }

    public class ImmediatlyAfterState : State
    {
        public int Level = 1;
        public ImmediatlyAfterState(HtmlTag tag, IEnumerable<Attribute> attribs, Action<string> triger)
        {
            TagName = tag;
            Attributes = ObjectGenerator.GenerateAttributes(attribs);
            Triger = triger;
            AttribCount = Attributes.Count(w => !string.IsNullOrEmpty(w));
            CurrentState = AttribCount;
            RemoveFromList = StateGroup.RemoveFromList;
            AddToList = StateGroup.AddToList;
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
            if (token.TokenType == TokenType.Attribute && Level == 1 && IsMatchTags(CurrentTag, TagName))
            {
                var attribute = ObjectGenerator.ConvertToAttribute(token);

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
                    if (NextState != null)
                    {
                        AddToList(NextState);
                        RemoveFromList(this);
                    }
                    else
                    {
                        Triger(NeededValue);
                        RemoveFromList(this);
                    }
                }
            }
            if (Level == -1)
            {
                RemoveFromList(this);
            }
        }
    }



    public class StateGroup
    {
        List<State> States;
        static List<State> TempStates;
        static List<State> RemoveStates;
        public static void AddToList(State state)
        {
           TempStates.Add(state);
        }
        public static void RemoveFromList(State state)
        {
            RemoveStates.Add(state);
        }
        public StateGroup(IEnumerable<State> states)
        {
            TempStates = new List<State>();
            RemoveStates = new List<State>();
            States = states.ToList();
        }
        public void ChangeState(HtmlToken token)
        {
            foreach (var item in States)
            {
                item.ChangeState(token);
            }
            if (TempStates.Count!=0)
            {
                States.AddRange(TempStates);
                TempStates.Clear();
            }
            if(RemoveStates.Count!=0)
            {
                foreach (var item in RemoveStates)
                {
                    States.Remove(item);
                }
                RemoveStates.Clear();
            }
        }
        public void QuerySelectorAll(IEnumerable<HtmlToken> tokens)
        {
            foreach (var token in tokens)
            {
                ChangeState(token);
            }
        }
    }


}
