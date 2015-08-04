using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;

namespace CssSelector
{
    public class HtmlAttributeGroup
    {
        public int Count;
        public int CurrentState;

        string NeededValue;
        public Action<string> Triger;
        public Action<Tag> AddToList;

        public Tag NextTag;
        string[] Attributes;

        public void Reset()
        {
            if(Count==0)
            {
                Count = Attributes.Where(w=>!string.IsNullOrEmpty(w)).Count();
            }
            CurrentState = Count;
        }
        public void GiveAttribute(Attribute attribute)
        {
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
        public HtmlAttributeGroup(string[] attribs, Action<string> triger)
        {
            Attributes = attribs;
            Triger = triger;
        }
    }
}
