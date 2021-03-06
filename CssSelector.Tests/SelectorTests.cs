﻿using System;
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
using CssSelector.Objects;

namespace CssSelector.Tests
{
    public class SelectorTests
    {
        HtmlToken[] tokens;
        public void Inicialize()
        {
            if (tokens != null) return;
            var k = new StreamReader(Directory.GetCurrentDirectory().Replace("bin\\Debug","") + "VGTimes.html").ReadToEnd();
            HtmlLexer lexer = new HtmlLexer();
            lexer.Load(k);
            tokens = lexer.Parse().ToArray();
        }

        [Fact]
        public void QuerySelector_Must_Do_SimpleSelects()
        {
            Inicialize();
            var list = new List<string>();
            var c = new Selector(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("[href=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 10);
        }

        [Fact]
        public void QuerySelector_Must_Do_SimpleSelects_With_Tag_Name()
        {
            Inicialize();
            var list = new List<string>();
            var c = new Selector(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("div[class=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 23);
        }

        [Fact]
        public void QuerySelector_Must_Do_Child_and_After_Selects()
        {
            Inicialize();
            var list = new List<string>();
            var c = new Selector(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("meta+link[rel=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 1);
        }

        [Fact]
        public void QuerySelector_Must_Do_Selects_Without_Attribs()
        {
            Inicialize();
            var list = new List<string>();
            var c = new Selector(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("head meta~link[rel=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count() == 3);
        }

        [Fact]
        public void ImmediatlyAfter_Test()
        {
            Inicialize();
            var list = new List<string>();
            var c = new Selector(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("head+body[id=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 1);
        }

        [Fact]
        public void ImmediatlyAfter_Deduction_Test()
        {
            Inicialize();
            var list = new List<string>();
            var c = new Selector(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("meta+script[type=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 0);
        }

        [Fact]
        public void DirectChild_Test()
        {
            Inicialize();
            var list = new List<string>();
            var c = new Selector(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("body div[class=add_material_cont]>div[class=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count >= 1);
        }

        [Fact]
        public void DirectChild_Test_Deduction()
        {
            Inicialize();
            var list = new List<string>();
            var c = new Selector(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("body>div[class=add_material_cont]>div[class=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 0);
        }

        [Fact]
        public void ImmediatlyAfter_Second_Test()
        {
            Inicialize();
            var list = new List<string>();
            var c = new Selector(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("a[href=/addarticle.html]~div[class=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 1);
        }

        [Fact]
        public void Child_Plus_After_Test()
        {
            Inicialize();
            var list = new List<string>();
            var c = new Selector(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("div[class=add_material_cont] h3~div[class=$result]", w => list.Add(w)),
            });
            c.QuerySelectorAll(tokens);
            Assert.True(list.Count == 1);
        }
    }
}