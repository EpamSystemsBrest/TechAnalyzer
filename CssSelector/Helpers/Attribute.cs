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
        public int Id;

        public Attribute() { }
        public Attribute(string attribs)
        {
            Id = (int)SelectorParser.ParseAttributeName(attribs);
            Value = SelectorParser.ParseAttributeValue(attribs);
        }
        public Attribute(int name, string value)
        {
            Id = name;
            Value = value;
        }
        public override string ToString()
        {
            return '[' + ((HtmlAttribute)Id).ToString() + " = " + Value + ']';
        }
    }
}