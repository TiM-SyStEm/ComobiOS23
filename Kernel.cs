using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using ComobiOS23.src.System;
using System.Security.Cryptography.X509Certificates;
using ComobiOS23.src.System.CMD;
using System.Linq;

namespace ComobiOS23
{
    public class Kernel : Sys.Kernel
    {
        private static Shell main;
        private static FileSystem fs;
        private int t = 0;
        protected override void BeforeRun()
        {
            IOsteram.Clear();
            IOsteram.OutLN("Loading ComobiOS...");
            IOsteram.Out("FileSystem initialization ");
            fs = new();

            IOsteram.Clear();

            // End of loading signal
            Console.Beep();

            main = new();
        }

        protected override void Run()
        {
            int size = inpcmd()[0].Count;
        }
        private static List<string>[] inpcmd()
        {
            IOsteram.Out("$>");
            string input = Console.ReadLine();
            return new LexerParser(input).tokenize();
        }
    }
}
