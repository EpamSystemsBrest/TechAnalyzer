using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsParser.Lexer;
using Xunit;

namespace JsParser.Tests.Infrastructure
{
    public static class JsTestExtensions
    {
        public static void ShouldReturn(this string code, params string[] expectedItems)
        {
            var lexer = new JsLexer();
            lexer.Load(code);
            int i = 0;
            foreach (var item in lexer.Parse())
            {
                if (i >= expectedItems.Length) break;
                var expected = expectedItems[i++];
                //if (expected == "*") continue;
                var actual = item.ToString();
                Assert.Equal(expected, actual);
            }
        }
    }
}
