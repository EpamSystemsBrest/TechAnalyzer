using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;
using HtmlParser.Lexer;

namespace CssSelector.Objects
{
    internal abstract class State
    {
        protected HtmlTag TagName;
        internal string[] Attributes;
        internal State NextState;
        protected Action<string> Triger;
        protected Action<State> AddToList;
        protected Action<State> RemoveFromList;
        protected int CurrentState;
        protected int AttribCount;
        protected string NeededValue;
        protected HtmlTag CurrentTag;

        public abstract void ChangeState(HtmlToken token);
        protected bool IsMatchTags(HtmlTag current, HtmlTag needed)
        {
            if (current == HtmlTag.Custom) return false;
            if (needed == HtmlTag.Custom) return true;
            return current == needed;
        }
        public abstract State GetCopy();
    }
}