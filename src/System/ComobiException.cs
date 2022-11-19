using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComobiOS23.src.System
{
    internal class ComobiException
    {
        private string type;
        private string text;
        public ComobiException(string type, string text)
        {
            this.type = type;
            this.text = text;
            execute();
        }
        private void execute()
        {
            if(type != "" && text != "")
                IOsteram.OutLN($"[{type};{text}]", ConsoleColor.Red);
            else if(type == "")
                IOsteram.OutLN($"[{text}]", ConsoleColor.Red);
            else if (text == "")
                IOsteram.OutLN($"[{type}]", ConsoleColor.Red);
            else
                IOsteram.OutLN("[UNKNOW ERROR]", ConsoleColor.Red);
        }
    }
}
