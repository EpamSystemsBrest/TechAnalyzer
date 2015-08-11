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
            TempStates.Add(state.GetCopy());
        }
        internal static void RemoveFromList(State state)
        {
            RemoveStates.Add(state);
        }
        private bool CompareStates(State state1, State state2)
        {
            return state1.Attributes == state2.Attributes && state1.TagName == state2.TagName && state1.Level == state2.Level;
        }
        public void AddNewStates()
        {
            foreach (var item in TempStates)
            {
                if (item is AfterState || item is ImmediatlyAfterState)
                {
                    if (!States.Any(w => CompareStates(w, item)))
                    {
                        States.Add(item);
                    }
                }
                else
                {
                    States.Add(item);
                }
            }
            TempStates.Clear();
        }
        public void RemoveIrrelevantStates()
        {
            foreach (var item in RemoveStates)
            {
                States.Remove(item);
            }
            RemoveStates.Clear();
        }
        private void ChangeState(HtmlToken token)
        {
            foreach (var item in States)
            {
                item.ChangeState(token);
            }
            AddNewStates();
            RemoveIrrelevantStates();
        }
        public void QuerySelectorAll(IEnumerable<HtmlToken> tokens)
        {
            foreach (var token in tokens)
            {
                ChangeState(token);
            }
        }
        public Selector(IEnumerable<Tuple<string, Action<string>>> selectors)
        {
            var states = selectors.Select(w => ObjectGenerator.GenerateStateNexus(w.Item1, w.Item2)).ToArray();
            TempStates = new List<State>();
            RemoveStates = new List<State>();
            States = states.ToList();
        }
    }
}
