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
        private JsToken currentToken;

        public void Load(Stream stream, Encoding encoding)
        {
            using (var reader = new StreamReader(stream, encoding))
            {
                Load(reader);
            }
        }

        public void Load(string code)
        {
            using (var reader = new StringReader(code))
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
            SkipWhitespace();
            while (!IsEof())
            {
                if (content[index].IsJsPunctuator())
                {
                    if (ParsePunctuator())
                        yield return currentToken;
                }
                else if (ParseWord())
                    yield return currentToken;
            }
        }

        private bool ParseWord()
        {
            int startIndex = index;
            GoToPunctuator();
            StringSegment value = new StringSegment(startIndex, index - startIndex);

            if (JsKeywordHash.IsJsKeyword(content, startIndex, index - startIndex))
                return FireToken(TokenType.Keyword, value);

            if (content[startIndex] == '\'' || content[startIndex] == '\"')
                return FireToken(TokenType.String, value);

            string stringValue = value.ToString(content);

            if(stringValue == "true" || stringValue == "false")
                return FireToken(TokenType.Boolean, value);

            if(stringValue == "null")
                return FireToken(TokenType.Null, value);

            double result;
            if (double.TryParse(stringValue, out result))
                return FireToken(TokenType.Numeric, value);

            return FireToken(TokenType.Identifier, value);
        }

        private bool ParsePunctuator()
        {
            throw new NotImplementedException();
        }

        private bool FireToken(TokenType tokenType, StringSegment value = default(StringSegment))
        {
            currentToken = new JsToken(tokenType, content, value);
            return true;
        }

        private bool IsEof()
        {
            return (index > length);
        }

        private void SkipWhitespace()
        {
            while ((index < length) && char.IsWhiteSpace(content[index])) index++;
        }

        private void SkipComment()
        {
            GoToChar('\n');
            index++;
        }

        private void SkipMultilineComment()
        {
            GoToSequence("*/");
            index += 2;
        }

        private void GoToPunctuator()
        {
            while ((index < length) && (!content[index].IsJsPunctuator())) index++;
        }

        private void GoToChar(char value)
        {
            while ((index < length) && (content[index] != value)) index++;
        }

        private void GoToSequence(string sequence)
        {
            var len = sequence.Length;

            while (index < length)
            {
                GoToChar(sequence[0]);
                if ((content[index + 1] == sequence[1]) &&
                    ((len < 3) || (content[index + 2] == sequence[2])) &&
                    ((len < 4) || (content[index + 3] == sequence[3])))
                {
                    break;
                }
                index++;
            }

        }
    }
}
