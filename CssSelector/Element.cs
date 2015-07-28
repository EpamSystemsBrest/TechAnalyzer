using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;

namespace CssSelector
{
    internal class Element
    {
        public HtmlTag Name;
        public IEnumerable<Attribute> Attributes;

        public Element() { }
        public Element(HtmlTag name)
        {
            Name = name;
        }

        public override string ToString()
        {
            if (Attributes == null)
            {
                return Name.ToString();
            }
            return Name + string.Join(string.Empty, Attributes.Select(w => '[' + w.Name + '=' + w.Value + ']'));
        }
        public string GetAttributeValue(HtmlAttribute attributeName)
        {
            if (Attributes == null || Attributes.All(w => w.Name != attributeName))
            {
                throw new ArgumentException("Attributes doesn't contain this attribute");
            }
            return Attributes.First(w => attributeName == w.Name).Value;
        }
    }
}