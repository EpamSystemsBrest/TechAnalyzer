using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;

namespace CssSelector
{
    internal class State
    {
        IEnumerable<Attribute> Attributes;
        HtmlAttribute NeededName;
        Action<string> Trigger;
        string INeedThis;
        int TestedState;
        HtmlTag Name;

        public State(string selector, Action<string> action)
        {
            Attributes = SelectorParser.ParseAttributes(selector);
            Name = SelectorParser.ParseHtmlTag(selector);
            Trigger = action;
            TestedState = Attributes.Count();
            if (Attributes.Any(w => w.Value == "$result"))
                NeededName = Attributes.First(w => w.Value == "$result").Name;
        }
        public void ChangeState(Element element)
        {
            int currentState = 0;
            if ((Name != HtmlTag.Custom && element.Name != Name) || Attributes == null) return;
            foreach (var item in element.Attributes)
            {
                if (Attributes.Any(w => w.Name == item.Name)
                    && item.Value == Attributes.First(w => w.Name == item.Name).Value)
                {
                    currentState += 1;
                }
                if (item.Name == NeededName)
                {
                    INeedThis = item.Value;
                    currentState += 1;
                }
                if (currentState == TestedState && !string.IsNullOrEmpty(INeedThis))
                {
                    Trigger(INeedThis);
                    return;
                }
            }
        }
    }
}