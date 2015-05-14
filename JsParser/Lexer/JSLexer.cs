using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JsParser.Lexer
{
    public class JSLexer
    {
        public readonly char[] content = new char[1024 * 1024];
        private int length;
        private int index;

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

        public IEnumerable<JSToken> Parse()
        {
            throw new NotImplementedException();
        }

        public void ParsePunctuator()
        {
            throw new NotImplementedException();
        }

        public void ParseKeyWord()
        {
            throw new NotImplementedException();
        }
    }
}
