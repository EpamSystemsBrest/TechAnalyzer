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
        private static readonly HtmlTag[] buttonScopeOpenTags = { HtmlTag.Div, HtmlTag.Ul, HtmlTag.P, HtmlTag.H1, HtmlTag.H2, HtmlTag.H3, HtmlTag.H4, HtmlTag.H5, HtmlTag.H6, HtmlTag.Ol, HtmlTag.Dl, HtmlTag.Fieldset,
                                                                  HtmlTag.Figcaption, HtmlTag.Figure, HtmlTag.Article, HtmlTag.Aside, HtmlTag.Blockquote, HtmlTag.Center, HtmlTag.Address, HtmlTag.Dialog, HtmlTag.Dir,
                                                                  HtmlTag.Summary, HtmlTag.Details, HtmlTag.Main, HtmlTag.Footer, HtmlTag.Header, HtmlTag.Nav, HtmlTag.Section, HtmlTag.Menu, HtmlTag.Hgroup, HtmlTag.Pre,
                                                                  HtmlTag.Listing, HtmlTag.Dd, HtmlTag.Dt, HtmlTag.Hr, HtmlTag.Xmp, HtmlTag.Plaintext };        

        private static readonly HtmlTag[] scopeCloseTags = { HtmlTag.Ol, HtmlTag.Ul, HtmlTag.Dl, HtmlTag.Fieldset, HtmlTag.Button, HtmlTag.Figcaption, HtmlTag.Figure, HtmlTag.Article, HtmlTag.Aside, HtmlTag.Blockquote,
                                                             HtmlTag.Center, HtmlTag.Address, HtmlTag.Dialog, HtmlTag.Div, HtmlTag.Summary, HtmlTag.Details, HtmlTag.Listing, HtmlTag.Footer, HtmlTag.Header, HtmlTag.Nav,
                                                             HtmlTag.Section, HtmlTag.Menu, HtmlTag.Hgroup, HtmlTag.Main, HtmlTag.Pre, HtmlTag.H1, HtmlTag.H2, HtmlTag.H3, HtmlTag.H4, HtmlTag.H5, HtmlTag.H6, HtmlTag.Dd,
                                                             HtmlTag.Dt, HtmlTag.Applet, HtmlTag.Marquee, HtmlTag.Object, HtmlTag.Button };        

        private static readonly HtmlTag[] scopedElements = { HtmlTag.Applet, HtmlTag.Caption, HtmlTag.Html, HtmlTag.Table, HtmlTag.Td, HtmlTag.Th, HtmlTag.Marquee, HtmlTag.Object, HtmlTag.Template, HtmlTag.Title };        

        private static readonly HtmlTag[] impliedEndTags = { HtmlTag.Dd, HtmlTag.Dt, HtmlTag.Li, HtmlTag.P, HtmlTag.Rp, HtmlTag.Rt, HtmlTag.Option, HtmlTag.Optgroup, HtmlTag.Rb, HtmlTag.Rtc };        

        private static readonly HtmlTag[] rubyTags = { HtmlTag.Rb, HtmlTag.Rtc, HtmlTag.Rp, HtmlTag.Rt };        

        private static readonly HtmlTag[] inTableOpenTags = { HtmlTag.Caption, HtmlTag.Colgroup, HtmlTag.Tbody, HtmlTag.Thead, HtmlTag.Tfoot };

        
        private List<HtmlToken> stackOfOpenElements;
        private List<HtmlToken> tokensQueue;
        private bool tokensReady = false;

        private HtmlToken CurrentTag
        {
            get { return stackOfOpenElements.Count > 0 ? stackOfOpenElements[stackOfOpenElements.Count - 1] : default(HtmlToken); }
        }

        public IEnumerable<HtmlToken> FixHtmlTags(IEnumerable<HtmlToken> htmlTokens)
        {
            stackOfOpenElements = new List<HtmlToken>();
            tokensQueue = new List<HtmlToken>();

            foreach (var token in htmlTokens)
            {
                if (token.TokenType == TokenType.OpenTag)
                {
                    var tokenName = token.GetTag();

                    if (buttonScopeOpenTags.Contains(tokenName) && IsInButtonScope())
                        GenerateImpliedEndTags();

                    else if (tokenName == HtmlTag.Li && IsInListItemScope())
                    {
                        ClearStackBackTo(HtmlTag.Li, HtmlTag.Dd, HtmlTag.Dt);
                        InsertCloseTag(tokenName);
                        stackOfOpenElements.Pop();
                    }

                    else if (tokenName == HtmlTag.Form && HtmlTag.Form.IsInStack(stackOfOpenElements) == false && IsInButtonScope())
                        GenerateImpliedEndTags();

                    else if (tokenName == HtmlTag.Button && IsInScope(tokenName))
                        GenerateImpliedEndTags();

                    else if (rubyTags.Contains(tokenName) && IsInScope(HtmlTag.Ruby))
                        GenerateImpliedEndTags();

                    //else if("table".IsInStack(stackOfOpenElements))
                    //{
                    //    if (inTableOpenTags.Contains(tokenName))
                    //        ClearStackBackTo("table");
                    //    if (tokenName == "td" || tokenName == "th" || tokenName == "tr")

                    //}

                    stackOfOpenElements.Push(token);
                }
                else if (token.TokenType == TokenType.CloseTag)
                {
                    var tokenName = token.GetTag();

                    if (tokenName == HtmlTag.Div && IsInScope(tokenName))
                    {
                        ClearStackBackTo(tokenName);
                        stackOfOpenElements.Pop();
                    }

                    else if (tokenName == HtmlTag.Li && IsInListItemScope())
                    {
                        ClearStackBackTo(HtmlTag.Li, HtmlTag.Dd, HtmlTag.Dt);
                        stackOfOpenElements.Pop();
                    }

                    else if (tokenName == HtmlTag.P && IsInButtonScope())
                    {
                        ClearStackBackTo(tokenName);
                        stackOfOpenElements.Pop();
                    }

                    else if (tokenName == HtmlTag.Form && HtmlTag.Form.IsInStack(stackOfOpenElements) && IsInScope(HtmlTag.Form))
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

                tokensQueue.Add(token);

                if(tokensReady)
                {
                    for (int i = 0; i < tokensQueue.Count - 2; i++)
                    {
                        yield return tokensQueue.Dequeue();
                    }

                    if (tokensQueue[0].TokenType != TokenType.OpenTag)
                        yield return tokensQueue.Dequeue();

                    tokensReady = false;
                }
            }

            foreach (var token in tokensQueue)
                yield return token;
        }

        private void GenerateImpliedEndTags()
        {
            var currentTag = CurrentTag;
            var currentTagName = currentTag.GetTag(); 

            while (impliedEndTags.Contains(currentTagName))
            {
                InsertCloseTag(currentTagName);
                stackOfOpenElements.Pop();
                currentTag = CurrentTag;
                currentTagName = currentTag.GetTag();
            }

            tokensReady = true;
        }

        private void ClearStackBackTo(params HtmlTag[] tagNames)
        {
            var currentTag = CurrentTag;
            var currentTagName = currentTag.GetTag();

            while (tagNames.Contains(currentTagName) == false && currentTagName != HtmlTag.Html && currentTagName != HtmlTag.Template)
            {
                InsertCloseTag(currentTagName);
                stackOfOpenElements.Pop();
                currentTag = CurrentTag;
                currentTagName = currentTag.GetTag();
            }

            tokensReady = true;
        }

        private void InsertCloseTag(HtmlTag insertTag)
        {
            tokensQueue.Add(new HtmlToken { TokenType = TokenType.CloseTag, hash = (int)insertTag });
        }

        private bool IsInScope(HtmlTag tagName)
        {
            for (int i = stackOfOpenElements.Count - 1; i >= 0; i--)
            {
                var currentTag = stackOfOpenElements[i];
                var currentTagName = currentTag.GetTag();

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
                var currentTagName = currentTag.GetTag();

                if (currentTagName == HtmlTag.P)
                    return true;
                else if (scopedElements.Contains(currentTagName) || currentTagName == HtmlTag.Button)
                    return false;
            }

            return false;
        }

        private bool IsInListItemScope()
        {
            for (int i = stackOfOpenElements.Count - 1; i >= 0; i--)
            {
                var currentTag = stackOfOpenElements[i];
                var currentTagName = currentTag.GetTag();

                if (currentTagName == HtmlTag.Li || currentTagName == HtmlTag.Dd || currentTagName == HtmlTag.Dt)
                    return true;
                else if (scopedElements.Contains(currentTagName) || currentTagName == HtmlTag.Ol || currentTagName == HtmlTag.Ul)
                    return false;
            }

            return false;
        }

        private void InBodyEndTagAnythingElse(HtmlTag tokenName)
        {
            var index = stackOfOpenElements.Count - 1;
            var currentTag = CurrentTag;

            while (index >= 0)
            {
                if (currentTag.GetTag() == tokenName)
                {
                    ClearStackBackTo(tokenName);
                    stackOfOpenElements.Pop();
                    break;
                }

                currentTag = stackOfOpenElements[--index];
            }
        }

    }

    public static class HtmlTokenExtensions
    {
        public static IEnumerable<HtmlToken> FixClosingTags(this IEnumerable<HtmlToken> tokens)
        {
            var parser = new HtmlParser();
            return parser.FixHtmlTags(tokens);
        }

        internal static void Pop(this List<HtmlToken> list)
        {
            list.RemoveAt(list.Count - 1);
        }

        internal static void Push(this List<HtmlToken> list, HtmlToken token)
        {
            list.Add(token);
        }

        internal static HtmlToken Dequeue(this List<HtmlToken> list)
        {
            var tempToken = list[0];
            list.RemoveAt(0);
            return tempToken;
        }

        //internal static string GetTagName(this HtmlToken token)
        //{
        //    return token.Name.Name.ToString(token.Source).ToLower();
        //}

        internal static bool IsInStack(this HtmlTag tagName, List<HtmlToken> stackOfOpenElements)
        {
            return stackOfOpenElements.Any(token => token.GetTag() == tagName);
        }
    }
}
