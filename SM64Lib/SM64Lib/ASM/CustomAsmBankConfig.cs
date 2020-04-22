using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.ASM
{
    public class CustomAsmBankConfig
    {
        public List<CustomAsmAreaConfig> Areas { get; } = new List<CustomAsmAreaConfig>();
        public int MaxLength { get; set; }
        public int Length { get; internal set; }
        public int RomStartAddress { get; set; }
    }
}
