using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;

namespace CssSelector
{
    internal class Attribute
    {
        public string Value;
        public HtmlAttribute Name;

        public Attribute() { }
        public Attribute(string attribs)
        {
            string tempName = attribs.Substring(1, attribs.IndexOf('=') - 1);
            Name = (HtmlAttribute)Enum.Parse(typeof(HtmlAttribute), ToUpperFirstChar(tempName));
            Value = attribs.Substring(attribs.IndexOf('=') + 1, attribs.Length - attribs.IndexOf('=') - 2);
        }
        public Attribute(HtmlAttribute name, string value)
        {
            Name = name;
            Value = value;
        }

        public static string ToUpperFirstChar(string str)
        {
            if (str[0] < 97 && str[0] > 122) return str;
            string g = (char)(str[0] - 32) + str.Substring(1, str.Length - 1);
            return g;
        }
    }
}