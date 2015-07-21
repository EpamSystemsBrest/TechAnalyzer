using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Lexer;
using CssSelector;
using System.IO;


namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlLexer lexer = new HtmlLexer();
            lexer.Load(new StreamReader("D:\\vgtimes.html").ReadToEnd());

            Selector sel = new Selector();
            sel.TokenSelector(lexer.Parse(), new List<Tuple<string, Action<string>>>()
            {
                new Tuple<string,Action<string>>("[tag=meta][name=$result]",w=>Console.WriteLine(w)),
                new Tuple<string,Action<string>>("[tag=meta][content=$result]",w=>Console.WriteLine(w))
            });

        }
    }
}
