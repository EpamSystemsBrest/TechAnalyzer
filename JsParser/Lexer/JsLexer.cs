using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using JsParser.Hash;

namespace JsParser.Lexer
{
    public class JsLexer
    {
        public readonly char[] content = new char[1024 * 1024];
        private int length;
        private int index;
        private JsToken currentToken;
        private Func<bool> parseAction;

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
            throw new NotImplementedException();
        }

        public bool ParseToken()
        {
            throw new NotImplementedException();
        }

        public bool ParsePunctuator(char symbol)
        {
            throw new NotImplementedException();
        }

        public void ParseKeyword()
        {
            throw new NotImplementedException();
        }

        public void ParseIdentifier()
        {
            throw new NotImplementedException();
        }

        private bool IsEof()
        {
            return (index >= length);
        }

        private void SkipWhitespace()
        {
            while ((index < length) && char.IsWhiteSpace(content[index])) index++;
        }

        private void SkipMultilineComment()
        {
            GoToSequence("*/");
            index += 2;
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
