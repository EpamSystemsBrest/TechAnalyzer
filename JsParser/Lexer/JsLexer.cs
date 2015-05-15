using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using JsParser.Hash;
using ParserCommon;

namespace JsParser.Lexer
{
    public class JsLexer
    {
        public readonly char[] content = new char[1024 * 1024];
        private int length;
        private int index;
        private int prevPunctuator;
        private JsToken currentToken;
        //private Func<bool> parseAction;

        public void Load(Stream stream, Encoding encoding)
        {
            using (var reader = new StreamReader(stream, encoding))
            {
                Load(reader);
            }
        }

        public void Load(string code)
        {
            using (var reader = new StreamReader(code))
            {
                Load(reader);
            }
        }

        public void Load(TextReader reader)
        {
            int startIndex = 0;
            int bytesRead = 1;
            while (bytesRead > 0)
            {
                bytesRead = reader.ReadBlock(content, startIndex, content.Length - startIndex);
                startIndex += bytesRead;
            }
            length = startIndex;
        }

        public IEnumerable<JsToken> Parse()
        {
            index = 0;
            //parseAction = ParseToken;
            while (index < length)
            {
                //if (!parseAction()) continue;
                yield return currentToken;
            }
        }

        private bool ParseToken()
        {
            if (index < length)
            {
                PunctuatorPosition();
                //ParseWord
                //parseAction= ParsePunctuator;
                prevPunctuator = index;
            }
            return false;
        }

        private void PunctuatorPosition()
        {
            while (!JsPunctuator.IsJsPunctuator(content[index]))
            {
                index++;
            }
        }

        private void ParseWord()
        {
            if (ParseKeyword()) return;
            else
            {
                //otherParse
            }
        }

        private bool ParsePunctuator(int startIndex)
        {
            throw new NotImplementedException();
        }

        public bool ParseKeyword() 
        {
            if (!JsKeywordHash.IsJsKeyword(content, prevPunctuator, index - prevPunctuator))
                return false;
            var tokenType = TokenType.Keyword;
            var value = new StringSegment(prevPunctuator,index - prevPunctuator);
            currentToken = new JsToken(tokenType, content, value);
            return true;
        }

        public void ParseIdentifier()
        {
            throw new NotImplementedException();
        }
    }
}
