using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CssSelector;
using Xunit;
using HtmlParser.Lexer;
using System.Net;
using HtmlParser;
using ParserCommon;
using System.Diagnostics;
using HtmlParser.Hash;
using System.IO;

namespace CssSelector.Tests
{
    public class SelectorTests
    {

        HtmlToken[] tokens;
        public void Inicialize()
        {
            if (tokens != null) return;
            var k = new StreamReader("VGTimes.html").ReadToEnd();
            HtmlLexer lexer = new HtmlLexer();
            lexer.Load(k);
            tokens = lexer.Parse().ToArray();
        }


        [Fact]
        public void QuerySelector_Must_Do_SimpleSelects()
        {
            Inicialize();
            var list = new List<string>();
            var c = ObjectGenerator.GenerateStateGroup(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("[style=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 26);
        }

        [Fact]
        public void QuerySelector_Must_Do_SimpleSelects_With_Tag_Name()
        {
            Inicialize();
            var list = new List<string>();
            var c = ObjectGenerator.GenerateStateGroup(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("div[style=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 21);
        }

        [Fact]
        public void QuerySelector_Must_Do_Child_and_After_Selects()
        {
            Inicialize();
            var list = new List<string>();
            var c = ObjectGenerator.GenerateStateGroup(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("div[class=header] ul[class=menu] a[href=/bestsellers/]~sup[style=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 1);
        }
    }
}