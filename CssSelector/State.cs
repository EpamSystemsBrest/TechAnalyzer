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
        HtmlTag Name;
        IEnumerable<Attribute> Attributes;
        HtmlAttribute NeededName;
        Action<string> Trigger;
        string INeedThis;
        int TestedState;

        public State(string selector, Action<string> action)
        {
            int index = selector.IndexOf('[');
            Attributes = GetAttributes(selector.Substring(index, selector.Length - index));
            if (index != 0)
            {
                string temp = Attribute.ToUpperFirstChar(selector.Substring(0, index));
                Name = (HtmlTag)Enum.Parse(typeof(HtmlTag), temp);
            }
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

        private IEnumerable<Attribute> GetAttributes(string selector)
        {
            int i1 = 0;
            int temp;
            string str;
            for (int i = 0; i < selector.Length; i++)
            {
                if (selector[i] == '[' || i == selector.Length - 1)
                {
                    temp = i == selector.Length - 1 ? i + 1 : i;
                    str = selector.Substring(i1, temp - i1);
                    if (!string.IsNullOrEmpty(str))
                    {
                        yield return new Attribute(selector.Substring(i1, temp - i1));
                    }
                    i1 = i;
                }
            }
        }
    }
}