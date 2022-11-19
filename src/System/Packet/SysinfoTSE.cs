using ComobiOS23.src.System.OpenTSE;
using System.Collections.Generic;

namespace ComobiOS23.src.System.Packet
{
    internal class SysinfoTSE : Executable
    {
        public static string Name = "sysinfo";
        public static uint TSE_VER = 1;
        public static uint TSE_TYPE = 1;
        public static Dictionary<uint, string> strdata = new Dictionary<uint, string>();
        public static uint[] code = {
        //  int         0x04
            0x02, 0x1C, 0x04, 0x0A,
        //  flp
            0x12, 0x0A,
        //  mov         a       x         0x01    
            0x01, 0x1C, 0x61, 0x78, 0x1C, 0x01, 0x0A,
        //  int         0x03
            0x02, 0x1C, 0x04, 0x0A,
        //  mov         b       x         0x02    
            0x01, 0x1C, 0x62, 0x78, 0x1C, 0x02, 0x0A,
        //  push        cmbverS
            0x10, 0x1C, 0x01, 0x0A,
        //  int         0x02
            0x02, 0x1C, 0x02, 0x0A,
        //  pop
            0x11, 0x0A,
        //  pop         d       x
            0x11, 0x1C, 0x64, 0x78, 0x0A,
        //  int         0x01
            0x02, 0x1C, 0x01, 0x0A,
        //  push        tseverS
            0x10, 0x1C, 0x02, 0x0A,
        //  int         0x02
            0x02, 0x1C, 0x02, 0x0A,
        //  pop
            0x11, 0x0A,
        //  pop         d       x
            0x11, 0x1C, 0x64, 0x78, 0x0A,
        //  int         0x01
            0x02, 0x1C, 0x01, 0x0A,
        //  push cpuinfoS
            0x10, 0x1C, 0x03, 0x0A,
        //  int         0x02
            0x02, 0x1C, 0x02, 0x0A,
        //  pop
            0x11, 0x0A,
        //  pop         d       x
            0x11, 0x1C, 0x64, 0x78, 0x0A,
        //  int         0x02
            0x02, 0x1C, 0x02, 0x0A,
        //  mov         d      x          comma
            0x01, 0x1C, 0x64, 0x78, 0x1C, 0x04, 0x0A,
        //  int         0x02
            0x02, 0x1C, 0x02, 0x0A,
        //  pop         d       x
            0x11, 0x1C, 0x64, 0x78, 0x0A,
        //  int         0x01
            0x02, 0x1C, 0x01, 0x0A,
        //  ret
            0x0, 0x0A
        };
        public static Dictionary<uint, uint> virtual_interrupts = new Dictionary<uint, uint>();
        public SysinfoTSE(){
            virtual_interrupts.Add(0x01, 0x01);
            virtual_interrupts.Add(0x02, 0x02);
            virtual_interrupts.Add(0x03, 0x03);
            virtual_interrupts.Add(0x04, 0x04);
            strdata.Add(0x01, "Comobi version: ");
            strdata.Add(0x02, "OpenTSE version: ");
            strdata.Add(0x03, "CPU: ");
            strdata.Add(0x04, ", ");
        }
    }
}
