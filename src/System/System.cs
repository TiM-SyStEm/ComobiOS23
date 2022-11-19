using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComobiOS23.src.System
{
    internal class System
    {
        private static string comobiVer = "23.0";
        private static uint curTSEVer = 1;
        public static string[] sysinfo()
        {
            return new string[] { comobiVer, curTSEVer.ToString(), CPU.GetCPUBrandString(), CPU.GetCPUVendorName()};
        }
    }
}
