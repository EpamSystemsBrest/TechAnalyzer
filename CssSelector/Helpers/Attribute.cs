using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;

namespace CssSelector
{
    public class Attribute
    {
        public string Value;
        public HtmlAttribute Name;

        public Attribute() { }
        public Attribute(string attribs)
        {
            Name = SelectorParser.ParseAttributeName(attribs);
            Value = SelectorParser.ParseAttributeValue(attribs);
        }
        public Attribute(HtmlAttribute name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}