﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Lexer;
using HtmlParser.Hash;
using HtmlParser;
using Xunit;

namespace HtmlParser.Test.Infrastructure
{
    public static class HtmlTestExtentions
    {

        public static void ShouldReturn(this string html, params string[] expectedItems)
        {
            var lexer = new HtmlLexer();
            lexer.Load(html);
            int i = 0;
            foreach (var item in lexer.Parse())
            {
                if (i >= expectedItems.Length) break;
                var expected = expectedItems[i++];
                if (expected == "*") continue;
                var actual = item.ToString();
                Assert.Equal(expected, actual);
            }
        }


        public static void TestHash(string[] values, Func<string, int> getHash)
        {
            var asserts = new List<string>();
            for (int i = 0; i < values.Length; i++)
            {
                var item = values[i];
                if (string.IsNullOrEmpty(item))
                    continue;
                var hash = getHash(item);
                if (hash != i)
                {
                    asserts.Add(string.Format("Value '{0}': Actual hash {1}, but expected {2}",
                                                     item, hash, i));
                }
            }
            if (asserts.Count > 0)
            {
                Assert.True(false, String.Join("\r\n", asserts));
            }
        }

        public static void ShouldBeFixedAs(this string html, string expectedHtml)
        {
            var lexer = new HtmlLexer();
            lexer.Load(html);
            var tokens = lexer.Parse();
            lexer = new HtmlLexer();
            lexer.Load(expectedHtml);
            var expectedTokens = lexer.Parse().ToList();
            var actualTokens = tokens.FixClosingTags();
            var i = 0;            
            foreach (var actualToken in actualTokens)
            {
                if (i > expectedTokens.Count) break;
                var expectedToken = expectedTokens[i++];
                if (actualToken.TokenType == TokenType.OpenTag || actualToken.TokenType == TokenType.CloseTag)
                {
                    Assert.Equal(expectedToken.GetTag(), actualToken.GetTag());
                    Assert.Equal(expectedToken.TokenType, actualToken.TokenType);
                }
                else
                    Assert.Equal(expectedToken.ToString(), actualToken.ToString());
            }
            if (i != expectedTokens.Count)
                throw new Xunit.Sdk.EqualException(expectedHtml, html);
        }
    }
}
