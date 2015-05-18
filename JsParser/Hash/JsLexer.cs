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
                if (content[index].IsPunctuator())
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
            {
                EndOfString();
                value = new StringSegment(startIndex, index - startIndex);
                return FireToken(TokenType.String, value);
            }   

            string stringValue = value.ToString(content);

            if (stringValue == "true" || stringValue == "false")
                return FireToken(TokenType.Boolean, value);

            if (stringValue == "null")
                return FireToken(TokenType.Null, value);

            if (char.IsDigit(stringValue[0]))
            {
                if (ContinuationNumeric())
                    value = new StringSegment(startIndex, index - startIndex);
                return FireToken(TokenType.Numeric, value);
            }

            return FireToken(TokenType.Identifier, value);
        }

        private bool ParsePunctuator()
        {
            int startIndex = index;

            if (char.IsWhiteSpace(content[index]))
            {
                SkipWhitespace();
                return false;
            }

            if (content[index].IsSingleCharPunctuator())
                return FirePunctuatorToken(startIndex, 1);

            // comment
            if (content[index] == '/')
            {
                if (content[index + 1] == '/')
                {
                    SkipComment();
                    return false;
                }
                else if (content[index + 1] == '*')
                {
                    SkipMultilineComment();
                    return false;
                }
            }

            // 4-character punctuator
            if (new string(content, index, 4) == ">>>=")
                return FirePunctuatorToken(startIndex, 4);

            // 3-character punctuator
            if (new string(content, index, 3).IsThreeCharPunctuator())
                return FirePunctuatorToken(startIndex, 3);

            // 2-character punctuator
            if (new string(content, index, 2).IsDoubleCharPunctuator())
                return FirePunctuatorToken(startIndex, 2);

            // 1-character punctuator
            return FirePunctuatorToken(startIndex, 1);
        }

        private bool FirePunctuatorToken(int startIndex, int punctuatorLength)
        {
            index += punctuatorLength;
            return FireToken(TokenType.Punctuator, new StringSegment(startIndex, punctuatorLength));
        }

        private bool FireNumericToken(int startIndex, int numericLength)
        {
            index += numericLength;
            return FireToken(TokenType.Numeric, new StringSegment(startIndex, numericLength));
        }

        private bool FireToken(TokenType tokenType, StringSegment value = default(StringSegment))
        {
            currentToken = new JsToken(tokenType, content, value);
            return true;
        }

        private bool ContinuationNumeric()
        {
            if (!content[index].IsDot()) return false;
            index++;
            GoToPunctuator();
            return true;
        }

        private int EndOfString() // TODO: finish function
        {
            var startIndex = index+1;
            var endIndex = startIndex;
            while (endIndex <length)
            {
                if (content[startIndex].IsScreening())
                {
                    endIndex = startIndex;
                }
                else if (content[startIndex].IsPunctuator())
                {
                    break;
                }
                startIndex++;
            }
            return endIndex;
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
            while ((index < length) && (!content[index].IsPunctuator())) index++;
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
