using System;
using System.Collections.Generic;

namespace ComobiOS23.src.System.OpenTSE
{
    internal interface Executable
    {
        public static string Name;
        public static uint TSE_VER;
        public static uint TSE_TYPE;
        public static Dictionary<uint, string> strdata;
        public static uint[] code;
        public static Dictionary<uint, uint> virtual_interrupts;

        string getName()
        {
            return Name;
        }
        uint getTSEVER()
        {
            return TSE_VER;
        }
        uint getTSETYPE()
        {
            return TSE_TYPE;
        }
        Dictionary<uint, string> getStrData()
        {
            return strdata;
        }
        uint[] getCode()
        {
            return code;
        }
        Dictionary<uint, uint> getVirtualInts()
        {
            return virtual_interrupts;
        }
    }
}
