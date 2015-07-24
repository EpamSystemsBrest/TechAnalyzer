using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using HtmlParser.Lexer;
using ParserCommon;
using HtmlParser.Hash;

namespace CssSelector
{
    public class Attribute
    {
        public HtmlAttribute Name;
        public string Value;
        public Attribute() { }
        public Attribute(string attribs)
        {
            string tempName = attribs.Substring(1, attribs.IndexOf('=') - 1);
            char temp = (char)(Char.IsUpper(tempName[0]) ? tempName[0] : tempName[0] - 32);
            Name = (HtmlAttribute)Enum.Parse(typeof(HtmlAttribute), temp + tempName.Substring(1, tempName.Length - 1));
            Value = attribs.Substring(attribs.IndexOf('=') + 1, attribs.Length - attribs.IndexOf('=') - 2);
        }
        public Attribute(HtmlAttribute name, string value)
        {
            Name = name;
            Value = value;
        }
    }

    public class Element
    {
        public HtmlParser.Hash.HtmlTag Name;
        public IEnumerable<Attribute> Attributes;
        public IEnumerable<Element> Children;
        public Element(HtmlParser.Hash.HtmlTag name)
        {
            Name = name;
        }
        public Element() { }
        public string GetAttributeValue(HtmlAttribute attributeName)
        {
            if (Attributes == null || Attributes.All(w => w.Name != attributeName))
            {
                throw new ArgumentException("Attributes doesn't contain inputed attribute");
            }
            return Attributes.First(w => attributeName == w.Name).Value;
        }
        public override string ToString()
        {
            if (Attributes == null)
            {
                return Name.ToString();
            }
            return Name + string.Join("", Attributes.Select(w => "[" + w.Name + " = " + w.Value + "]"));
        }
    }

    public class Selector
    {
        Element Root;
        public IEnumerable<State> States;
        public Selector(Element root)
        {
            Root = root;
        }
        public Selector()
        {

        }
        public void TokenSelector(IEnumerable<HtmlToken> tokens, IEnumerable<Tuple<string, Action<string>>> selectors)
        {
            States = selectors.Select(w => new State(w.Item1, w.Item2));
            Element temp = new Element();
            var attribs = new List<Attribute>();
            foreach (var item in tokens)
            {
                if (item.TokenType == TokenType.Attribute)
                {
                    attribs.Add(new Attribute(item.GetAttribute(), String.Concat(item.Source.Skip(item.Value.StartIndex).Take(item.Value.Length))));
                }
                if (item.TokenType == TokenType.OpenTag || item.TokenType == TokenType.CloseTag)
                {
                    if (item.TokenType == TokenType.OpenTag)
                    {
                        temp.Name = item.GetTag();
                    }
                    temp.Attributes = attribs;
                    foreach (var state in States)
                    {
                        state.ChangeState(temp);
                    }
                    attribs.Clear();
                }
            }
        }
    }

    public class State
    {
        #region Fields
        IEnumerable<Attribute> Attributes;
        Dictionary<HtmlAttribute, int> Dict;
        Action<string> Trigger;
        public HtmlTag Name;
        int CurrentState;
        int TestetState;
        HtmlAttribute NeededName;
        string INeedThis;
        int Dim;
        #endregion

        public State(string selector, Action<string> action)
        {
            if (selector == "*") return;
            int index = selector.IndexOf('[');
            Attributes = GetAttributes(selector.Substring(index, selector.Length - index));
            if (index != 0)
            {
                string temp = selector.Substring(0, index);
                if (!Char.IsUpper(temp[0]))
                {
                    temp = (char)(temp[0] - 32) + temp.Substring(1, temp.Length - 1);
                }
                Name = (HtmlTag)Enum.Parse(typeof(HtmlTag), temp);
            }
            Dim = Attributes.Count();
            Dict = Attributes
                    .Select((w, ii) => new Tuple<HtmlAttribute, int>(w.Name, ii))
                    .ToDictionary(w => w.Item1, w => w.Item2 + 1);
            Trigger = action;
            CurrentState = 0;
            TestetState = Dict.Count;
            if (Attributes.Any(w => w.Value == "$result"))
                NeededName = Attributes.First(w => w.Value == "$result").Name;
        }
        public void ChangeState(Element element)
        {
            if ((Name != HtmlTag.Custom && element.Name != Name) || Attributes == null) return;

            foreach (var item in element.Attributes)
            {
                if (Attributes.Any(w => w.Name == item.Name)
                    && item.Value == Attributes.First(w => w.Name == item.Name).Value)
                {
                    CurrentState += 1;
                }
                if (item.Name == NeededName)
                {
                    INeedThis = item.Value;
                    CurrentState += 1;
                }
                if (CurrentState == TestetState)
                {
                    if (string.IsNullOrEmpty(INeedThis))
                    {
                        return;
                    }
                    else
                    {
                        Trigger(INeedThis);
                        return;
                    }
                }
            }
            return;
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