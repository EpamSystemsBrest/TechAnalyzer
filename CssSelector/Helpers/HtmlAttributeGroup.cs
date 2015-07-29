using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;

namespace CssSelector
{
    internal class HtmlAttributeGroup
    {
        public int Count;
        public int CurrentState;
        string NeededValue;
        Action<string> Triger;
        IEnumerable<Attribute> Attributes;

        public void Reset()
        {
            if(Count==0)
            {
                Count = Attributes.Count();
            }
            CurrentState = Count;
        }
        public override string ToString()
        {
            return string.Join("", Attributes);
        }
        public void GiveAttribute(Attribute attribute)
        {
            foreach (var item in Attributes)
            {
                if(item.Id == attribute.Id)
                {
                    if(item.Value == attribute.Value)
                    {
                        CurrentState -= 1;
                    }
                    if(item.Value == "$result")
                    {
                        CurrentState -= 1;
                        NeededValue = attribute.Value;
                    }
                    if(CurrentState == 0)
                    {
                        Triger(NeededValue);
                    }
                    return;
                }
            }
        }
        public HtmlAttributeGroup(IEnumerable<Attribute> attribs, Action<string> triger)
        {
            Attributes = attribs;
            Triger = triger;
        }
    }
}
