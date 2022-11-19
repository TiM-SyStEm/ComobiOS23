using System.Collections.Generic;

namespace ComobiOS23.src.System.CMD
{
    internal class LexerParser
    {
        private string input;
        private int length;
        private int pos = 0;
        private int objNum = 0;
        private string buffer = string.Empty;
        private int mode = 0;

        private List<string> args;
        private List<string> flags;
        private List<string> cmd;
        public LexerParser(string input)
        {
            this.input = input;
            this.length = input.Length;
        }

        public List<string>[] tokenize() {
            char current;
            while (pos <= length) {
                current = input[pos];
                switch (current)
                {
                    case '-':
                        tokenizeFlag(current);
                        break;
                    default:
                        if (mode == 1)
                        {
                            tokenizeFlag(current);
                        }
                        else if (mode == 2 && objNum != 0) {
                            tokenizeArgument(current);
                        };
                        break;
                }
                pos++;
                objNum++;
            }
            return new List<string>[] { cmd, args, flags };
        }
        private void tokenizeArgument(char currentS)
        {
            if(currentS == ' ')
            {
                if (objNum != 0)
                    args.Add(buffer);
                else if (objNum == 0) cmd.Add(buffer);
                mode = 0;
                buffer = string.Empty;
                return;
            }
            buffer += currentS;
            mode = 2;
        }
        private void tokenizeFlag(char currentS)
        {
            if (currentS == '-') return;
            if(currentS == ' ')
            {
                flags.Add(buffer);
                mode = 0;
                buffer = string.Empty;
                return;
            }
            buffer += currentS;
            mode = 1;
        }
    }
}
