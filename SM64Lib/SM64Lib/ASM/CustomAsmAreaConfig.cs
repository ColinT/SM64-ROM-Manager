using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.ASM
{
    public class CustomAsmAreaConfig
    {
        public int RomAddress { get; internal set; } = -1;
        public int Length { get; internal set; } = 0;
    }
}
