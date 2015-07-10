using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Lexer;
using HtmlParser.Hash;

namespace HtmlParser
{
    public class HtmlParser
    {
        private static readonly string[] buttonScopeOpenTags = {"div","li","ul","p","h1","h2","h3","h4","h5","h6","ol","dl","fieldset","figcaption","figure","article","aside","blockquote",
                                                                "center","address","dialog","dir","summary","details","main","footer","header","nav","section","menu","hgroup","pre","listing",
                                                                "dd","dt","hr","xmp","plaintext"}; //+ </p> + <table>

        private static readonly string[] scopeCloseTags = {"ol","ul","dl","fieldset","button","figcaption","figure","article","aside","blockquote","center","address","dialog","div",
                                                           "summary","details","listing","footer","header","nav","section","menu","hgroup","main","pre","h1","h2","h3","h4","h5","h6",
                                                           "dd","dt","applet","marquee","object","button"};

        private static readonly string[] scopedElements = { "applet", "caption", "html", "table", "td", "th", "marquee", "object", "template", "title" };
                                                            // + mi mo mn ms mtext annotation-xml foreignObject dese

        private static readonly string[] impliedEndTags = { "dd", "dt", "li", "p", "rp", "rt", "option", "optgroup", "rb", "rtc" };
        //private static readonly HtmlTag[] impliedEndTags = { HtmlTag.Dd, HtmlTag.Dt, HtmlTag.Li, HtmlTag.P, HtmlTag.Rp, HtmlTag.Rt, HtmlTag.Option, HtmlTag.Optgroup, HtmlTag.Rb, HtmlTag.Rtc };


        private IEnumerable<HtmlToken> htmlTokens;
        private List<HtmlToken> stackOfOpenElements;
        private StringBuilder fixedHtml;
        private int indexShift;

        private HtmlToken CurrentTag
        {
            get { return stackOfOpenElements.Count > 0 ? stackOfOpenElements[stackOfOpenElements.Count - 1] : default(HtmlToken); }
        }

        public string FixHtmlTags(string html)
        {
            var lexer = new HtmlLexer();
            lexer.Load(html);
            htmlTokens = lexer.Parse();
            indexShift = 0;
            fixedHtml = new StringBuilder(html);

            foreach (var token in htmlTokens)
            {
                var tokenType = token.TokenType;
                var tokenName = token.Name.Name.ToString(token.Source);

                if(tokenType == TokenType.OpenTag)
                {

                }
                else if(tokenType == TokenType.CloseTag)
                {

                }
            }

            throw new NotImplementedException();
        }

        private void GenerateImpliedEndTags()
        {
            var currentTag = CurrentTag;
            var currentTagName = currentTag.GetTagName();

            while(impliedEndTags.Contains(currentTagName))
            {
                //TODO: insert closing tag in sb
                //
                stackOfOpenElements.Pop();
            }
        }

        private void ClearStackBackTo(string tagName)
        {
            var currentTag = CurrentTag;
            var currentTagName = currentTag.GetTagName();

            while (currentTagName != tagName && currentTagName != "html" && currentTagName != "template")
            {
                // TODO: insert closing tag in sb if needed
                //
                stackOfOpenElements.Pop();
                currentTag = CurrentTag;
            }
        }

        private bool IsInScope(string tagName)
        {
            for (int i = stackOfOpenElements.Count - 1; i >= 0; i--)
            {
                var currentTag = stackOfOpenElements[i];
                var currentTagName = currentTag.GetTagName();

                if (currentTagName == tagName)
                    return true;
                else if (scopedElements.Contains(currentTagName))
                    return false;
            }

            return false;
        }

        private bool IsInButtonScope()
        {
            for (int i = stackOfOpenElements.Count - 1; i >= 0; i--)
            {
                var currentTag = stackOfOpenElements[i];
                var currentTagName = currentTag.GetTagName();

                if (currentTagName == "p")
                    return true;
                else if (scopedElements.Contains(currentTagName) || currentTagName == "button")
                    return false;
            }

            return false;
        }

    }

    static class Extensions
    {
        //internal static HtmlToken Pop(this List<HtmlToken> list)
        //{
        //    var temp = list[list.Count - 1];
        //    list.RemoveAt(list.Count - 1);
        //    return temp;
        //}

        internal static void Pop(this List<HtmlToken> list)
        {            
            list.RemoveAt(list.Count - 1);         
        }

        internal static void Push(this List<HtmlToken> list, HtmlToken token)
        {
            list.Add(token);
        }

        internal static string GetTagName(this HtmlToken token)
        {
            return token.Name.Name.ToString(token.Source).ToLower();
        }
    }
}
