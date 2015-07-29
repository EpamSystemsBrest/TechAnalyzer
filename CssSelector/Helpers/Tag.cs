using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;

namespace CssSelector
{
    public class Tag
    {
        public HtmlTag TagName;
        public IEnumerable<HtmlAttributeGroup> AttributesGroups;

        public void ChangeState(Attribute attribute)
        {
            foreach (var group in AttributesGroups.Where(w=>w.CurrentState!=0))
            {
                group.GiveAttribute(attribute);
            }
        }
        public void ResetAll()
        {
            foreach (var group in AttributesGroups.Where(w=>w.Count==0 || w.Count != w.CurrentState))
            {
                group.Reset();
            }
        }
    }
}
