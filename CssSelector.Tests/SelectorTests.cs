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

namespace CssSelector.Tests
{
    public class SelectorTests
    {
        HtmlToken[] tokens = new HtmlToken[]
            {
                new HtmlToken(TokenType.OpenTag, "html".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.OpenTag, "head".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.OpenTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                        new HtmlToken(TokenType.Attribute, "http-equiv=\"X-UA-Compatible\"".ToArray(), new QualifiedName(0, 10), new StringSegment(12, 15)),
                        new HtmlToken(TokenType.Attribute, "content=\"IE=10\"".ToArray(), new QualifiedName(0, 7), new StringSegment(9, 5)),
                    new HtmlToken(TokenType.CloseTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.OpenTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 3)),
                        new HtmlToken(TokenType.Attribute, "name=\"GENERATOR\"".ToArray(), new QualifiedName(0, 4), new StringSegment(6, 9)),
                    new HtmlToken(TokenType.CloseTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.CloseTag, "head".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.OpenTag, "body".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.OpenTag, "div".ToArray(), new QualifiedName(0, 3), new StringSegment(0, 3)),
                        new HtmlToken(TokenType.Attribute, "id=\"13\"".ToArray(), new QualifiedName(0, 2), new StringSegment(4, 2)),
                        new HtmlToken(TokenType.Attribute, "name=\"wraper\"".ToArray(), new QualifiedName(0, 4), new StringSegment(6, 6)),
                        new HtmlToken(TokenType.Attribute, "class=\"maindiv\"".ToArray(), new QualifiedName(0, 5), new StringSegment(7, 7)),
                    new HtmlToken(TokenType.CloseTag, "div".ToArray(), new QualifiedName(0, 3), new StringSegment(0, 3)),
                    new HtmlToken(TokenType.CloseTag, "body".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                new HtmlToken(TokenType.CloseTag, "html".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4))
            };

        [Fact]
        public void TokenSelector_Must_Do_Tokens_From_HtmToken_Sequence()
        {
            Selector sel = new Selector();
            var list = new List<string>();

            sel.TokenSelector(tokens, new List<Tuple<string, Action<string>>>()
                {
                    new Tuple<string,Action<string>>("meta[httpequiv=$result]",w=>list.Add(w + " - Selector1")),
                    new Tuple<string,Action<string>>("div[id=13][name=$result]",w=>list.Add(w + " - Selector3")),
                    new Tuple<string,Action<string>>("meta[content=$result]",w=>list.Add(w + " - Selector4"))
                });

            Assert.True(list.ElementAt(0) == "X-UA-Compatible - Selector1"
                     && list.ElementAt(1) == "IE=10 - Selector4"
                     && list.ElementAt(2) == "wraper - Selector3");
        }

        [Fact]
        public void TokenSelector_Must_Do_Tokens_With_Tag_Name()
        {
            Selector sel = new Selector();
            var list = new List<string>();

            sel.TokenSelector(tokens, new List<Tuple<string, Action<string>>>()
                {
                    new Tuple<string,Action<string>>("div[id=$result]",w=>list.Add(w)),
                });

            Assert.True(list.ElementAt(0) == "13");
        }

        [Fact]
        public void TokenSelector_Must_Do_Nothing_If_Sequence_Is_Empty()
        {
            Selector sel = new Selector();
            var list = new List<string>();
            sel.TokenSelector(Enumerable.Empty<HtmlToken>(), new List<Tuple<string, Action<string>>>()
                {
                    new Tuple<string,Action<string>>("[httpequiv=$result]",w=>list.Add(w + " - Selector1")),
                    new Tuple<string,Action<string>>("[name=$result]",w=>list.Add(w + " - Selector2")),
                    new Tuple<string,Action<string>>("[id=13][name=$result]",w=>list.Add(w + " - Selector3")),
                    new Tuple<string,Action<string>>("[content=$result]",w=>list.Add(w + " - Selector4"))
                });

            Assert.True(list.Count == 0);
        }

        [Fact]
        public void NewTestSomething()
        {
            var group1 = new HtmlAttributeGroup(ObjectGenerator.GenerateAttributes(new List<Attribute>()
            {
                new Attribute("[name=fsdfsdfsdfdsf"),
                new Attribute("[value=fsfsfsdfsdfsdf]")
            }),w=> { });

            var group2 = new HtmlAttributeGroup(ObjectGenerator.GenerateAttributes(new List<Attribute>()
            {
                new Attribute("[name=lol"),
                new Attribute("[value=15]")
            }), w => { });

            var group3 = new HtmlAttributeGroup(ObjectGenerator.GenerateAttributes(new List<Attribute>()
            {
                new Attribute("[name=vova"),
                new Attribute("[value=assassin]")
            }), w => { });

            var tag1 = new ChildTag(HtmlTag.Div, new List<HtmlAttributeGroup>() { group1, group2 });
            var tag2 = new ChildTag(HtmlTag.Div, new List<HtmlAttributeGroup>() { group3, group2 });
            tag1.NextTag = tag2;

            var dict = new Dictionary<HtmlTag, Tag>();
            dict.Add(tag1.TagName, tag1);
            var tagGroup = new TagGroup(dict);
        }

        [Fact]
        public void TokenSelector_Must_Do_Simple_Selects_Right()
        {
            Selector sel = new Selector();
            var list = new List<string>();
            sel.TokenSelector(tokens, new List<Tuple<string, Action<string>>>()
                {
                    new Tuple<string,Action<string>>("[name=$result]",w=>list.Add(w))
                });

            Assert.True(list.ElementAt(0) == "GENERATOR" && list.ElementAt(1) == "wraper");
        }
    }
}