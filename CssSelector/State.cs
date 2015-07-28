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
        public IEnumerable<Attribute> Attributes;
        public HtmlAttribute NeededName;
        public Action<string> Trigger;
        public string INeedThis;
        public int TestedState;
        public HtmlTag Name;

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