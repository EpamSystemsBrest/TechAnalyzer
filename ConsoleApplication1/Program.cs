using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Hash;
using HtmlParser.Lexer;
using CssSelector;
using ParserCommon;
using CssSelector.Objects;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlToken[] tokens = new HtmlToken[]
            {
                new HtmlToken(TokenType.OpenTag, "html".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.OpenTag, "head".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.Attribute, "content=\"IE=10\"".ToArray(), new QualifiedName(0, 7), new StringSegment(9, 5)),
                    new HtmlToken(TokenType.OpenTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                        new HtmlToken(TokenType.Attribute, "http-equiv=\"X-UA-Compatible\"".ToArray(), new QualifiedName(0, 10), new StringSegment(12, 15)),
                        new HtmlToken(TokenType.Attribute, "content=\"IE=11\"".ToArray(), new QualifiedName(0, 7), new StringSegment(9, 5)),
                            new HtmlToken(TokenType.OpenTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                                new HtmlToken(TokenType.Attribute, "name=\"GENERATOR\"".ToArray(), new QualifiedName(0, 4), new StringSegment(6, 9)),
                                    new HtmlToken(TokenType.OpenTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                                        new HtmlToken(TokenType.Attribute, "name=\"GENERATOI\"".ToArray(), new QualifiedName(0, 4), new StringSegment(6, 9)),
                                    new HtmlToken(TokenType.CloseTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                            new HtmlToken(TokenType.CloseTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.CloseTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.OpenTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 3)),
                        new HtmlToken(TokenType.Attribute, "name=\"GENERATOR\"".ToArray(), new QualifiedName(0, 4), new StringSegment(6, 9)),
                    new HtmlToken(TokenType.CloseTag, "meta".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.CloseTag, "head".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                    new HtmlToken(TokenType.OpenTag, "body".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                        new HtmlToken(TokenType.Attribute, "name=\"bobody\"".ToArray(), new QualifiedName(0, 4), new StringSegment(6, 6)),
                    new HtmlToken(TokenType.OpenTag, "div".ToArray(), new QualifiedName(0, 3), new StringSegment(0, 3)),
                        new HtmlToken(TokenType.Attribute, "id=\"13\"".ToArray(), new QualifiedName(0, 2), new StringSegment(4, 2)),
                        new HtmlToken(TokenType.Attribute, "name=\"wraper\"".ToArray(), new QualifiedName(0, 4), new StringSegment(6, 6)),
                        new HtmlToken(TokenType.Attribute, "class=\"maindiv\"".ToArray(), new QualifiedName(0, 5), new StringSegment(7, 7)),
                    new HtmlToken(TokenType.CloseTag, "div".ToArray(), new QualifiedName(0, 3), new StringSegment(0, 3)),
                    new HtmlToken(TokenType.CloseTag, "body".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4)),
                new HtmlToken(TokenType.CloseTag, "html".ToArray(), new QualifiedName(0, 4), new StringSegment(0, 4))
            };

            var c = ObjectGenerator.GenerateStateGroup(new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string, Action<string>>("body[name=bobody] div[name=$result]", w=>Console.WriteLine(w + " - Selector1")),
                new Tuple<string, Action<string>>("head[content=$result]", w=>Console.WriteLine(w + " - Selector2"))
            });

            foreach (var item in tokens)
            {
                c.ChangeState(item);
            }
        }
    }
}
