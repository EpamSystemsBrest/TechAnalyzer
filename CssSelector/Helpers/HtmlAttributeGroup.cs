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
        public IEnumerable<Attribute> Attributes;
        public Action<string> Triger;
        public int CurrentState;
        public int Count;
        string NeededValue;

        public void Reset()
        {
            if(Count==0)
            {
                Count = Attributes.Count();
            }
            CurrentState = Count;
        }
        public void GiveAttribute(Attribute attribute)
        {
            foreach (var item in Attributes)
            {
                if(item.Name == attribute.Name)
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
                    break;
                }
            }
        }
    }
}
