using System;
using System.Collections.Generic;
using System.Linq;
using HtmlParser.Hash;
using HtmlParser.Lexer;

namespace CssSelector.Objects
{
    public class Selector
    {
        List<State> States;
        static List<State> TempStates;
        static List<State> RemoveStates;
        internal static void AddToList(State state)
        {
            TempStates.Add(state);
        }
        internal static void RemoveFromList(State state)
        {
            RemoveStates.Add(state);
        }
        internal Selector(IEnumerable<State> states)
        {
            TempStates = new List<State>();
            RemoveStates = new List<State>();
            States = states.ToList();
        }
        private void ChangeState(HtmlToken token)
        {
            foreach (var item in States)
            {
                item.ChangeState(token);
            }
            if (TempStates.Count != 0)
            {
                States.AddRange(TempStates);
                TempStates.Clear();
            }
            if (RemoveStates.Count != 0)
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
