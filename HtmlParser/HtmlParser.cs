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
        private static readonly string[] buttonScopeOpenTags = {"div","ul","p","h1","h2","h3","h4","h5","h6","ol","dl","fieldset","figcaption","figure","article","aside","blockquote",
                                                                "center","address","dialog","dir","summary","details","main","footer","header","nav","section","menu","hgroup","pre","listing",
                                                                "dd","dt","hr","xmp","plaintext"};

        private static readonly string[] scopeCloseTags = {"ol","ul","dl","fieldset","button","figcaption","figure","article","aside","blockquote","center","address","dialog","div",
                                                           "summary","details","listing","footer","header","nav","section","menu","hgroup","main","pre","h1","h2","h3","h4","h5","h6",
                                                           "dd","dt","applet","marquee","object","button"};

        private static readonly string[] scopedElements = { "applet", "caption", "html", "table", "td", "th", "marquee", "object", "template", "title" };
                                                            // + mi mo mn ms mtext annotation-xml foreignObject dese

        private static readonly string[] impliedEndTags = { "dd", "dt", "li", "p", "rp", "rt", "option", "optgroup", "rb", "rtc" };

        private static readonly string[] rubyTags = { "rb", "rtc", "rp", "rt" };


        private IEnumerable<HtmlToken> htmlTokens;
        private List<HtmlToken> stackOfOpenElements;
        private StringBuilder fixedHtml;
        private int insertPosition;
        private int indexShift;

        private HtmlToken CurrentTag
        {
            get { return stackOfOpenElements.Count > 0 ? stackOfOpenElements[stackOfOpenElements.Count - 1] : default(HtmlToken); }
        }

        private int InsertPosition
        {
            get { return insertPosition + indexShift; }
        }


        public string FixHtmlTags(string html)
        {
            var lexer = new HtmlLexer();
            lexer.Load(html);
            htmlTokens = lexer.Parse();
            stackOfOpenElements = new List<HtmlToken>();
            indexShift = 0;
            fixedHtml = new StringBuilder(html);

            foreach (var token in htmlTokens)
            {
                var tokenName = token.GetTagName();

                if (token.TokenType == TokenType.OpenTag)
                {
                    insertPosition = token.Name.Name.StartIndex - 1;

                    if (buttonScopeOpenTags.Contains(tokenName) && IsInButtonScope())
                        GenerateImpliedEndTags();

                    else if (tokenName == "li" && IsInListItemScope())
                    {
                        ClearStackBackTo("li", "dd", "dt");
                        InsertCloseTag(tokenName);
                        stackOfOpenElements.Pop();
                    }

                    else if (tokenName == "form" && "form".IsInStack(stackOfOpenElements) == false && IsInButtonScope())
                        GenerateImpliedEndTags();

                    else if (tokenName == "button" && IsInScope(tokenName))
                        GenerateImpliedEndTags();

                    else if (rubyTags.Contains(tokenName) && IsInScope("ruby"))
                        GenerateImpliedEndTags();

                    stackOfOpenElements.Push(token);
                }
                else if (token.TokenType == TokenType.CloseTag)
                {
                    insertPosition = token.Name.Name.StartIndex - 2;

                    if (tokenName == "div" && IsInScope(tokenName))
                    {
                        ClearStackBackTo(tokenName);
                        stackOfOpenElements.Pop();
                    }

                    else if (tokenName == "li" && IsInListItemScope())
                    {
                        ClearStackBackTo("li", "dd", "dt");
                        stackOfOpenElements.Pop();
                    }

                    else if (tokenName == "p" && IsInButtonScope())
                    {
                        ClearStackBackTo(tokenName);
                        stackOfOpenElements.Pop();
                    }

                    else if (tokenName == "form" && "form".IsInStack(stackOfOpenElements) && IsInScope("form"))
                    {
                        GenerateImpliedEndTags();
                        stackOfOpenElements.Remove(stackOfOpenElements.FindLast(t => t.GetTag() == HtmlTag.Form));
                    }

                    else if (scopeCloseTags.Contains(tokenName) && IsInScope(tokenName))
                    {
                        ClearStackBackTo(tokenName);
                        stackOfOpenElements.Pop();
                    }

                    else
                    {
                        InBodyEndTagAnythingElse(tokenName);
                    }
                }
            }

            return fixedHtml.ToString();
        }

        private void GenerateImpliedEndTags()
        {
            var currentTag = CurrentTag;
            var currentTagName = currentTag.GetTagName();

            while (impliedEndTags.Contains(currentTagName))
            {
                InsertCloseTag(currentTagName);
                stackOfOpenElements.Pop();
                currentTag = CurrentTag;
                currentTagName = currentTag.GetTagName();
            }
        }

        private void ClearStackBackTo(params string[] tagNames)
        {
            var currentTag = CurrentTag;
            var currentTagName = currentTag.GetTagName();

            while (tagNames.Contains(currentTagName) == false && currentTagName != "html" && currentTagName != "template")
            {
                InsertCloseTag(currentTagName);
                stackOfOpenElements.Pop();
                currentTag = CurrentTag;
                currentTagName = currentTag.GetTagName();
            }
        }

        private void InsertCloseTag(string insertTagName)
        {
            fixedHtml.Insert(InsertPosition, string.Format("</" + insertTagName + ">"));
            indexShift += insertTagName.Length + 3;
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

        private bool IsInListItemScope()
        {
            for (int i = stackOfOpenElements.Count - 1; i >= 0; i--)
            {
                var currentTag = stackOfOpenElements[i];
                var currentTagName = currentTag.GetTagName();

                if (currentTagName == "li" || currentTagName == "dd" || currentTagName == "dt")
                    return true;
                else if (scopedElements.Contains(currentTagName) || currentTagName == "ol" || currentTagName == "ul")
                    return false;
            }

            return false;
        }

        private void InBodyEndTagAnythingElse(string tokenName)
        {
            var index = stackOfOpenElements.Count - 1;
            var currentTag = CurrentTag;

            while (index >= 0)
            {
                if (currentTag.GetTagName() == tokenName)
                {
                    ClearStackBackTo(tokenName);
                    stackOfOpenElements.Pop();
                    break;
                }

                currentTag = stackOfOpenElements[--index];
            }
        }

    }

    static class HtmlTokenExtensions
    {
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

        internal static bool IsInStack(this string tagName, List<HtmlToken> stackOfOpenElements)
        {
            return stackOfOpenElements.Any(token => token.GetTagName() == tagName);
        }
    }
}
