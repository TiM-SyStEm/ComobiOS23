using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComobiOS23.src.System.OpenTSE
{
    internal class ExecuteTSEFile
    {
        private static int size;
        public static void execute(Executable program)
        {
            size = program.getCode().Length;
        }
    }
}
