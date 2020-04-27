using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.ASM
{
    public class CustomAsmBankConfig
    {
        public static int DefaultMaxLength { get; set; } = 0xA000;
        public static int DefaultRomStartAddress { get; internal set; } = 0x1205000;
        public static int DefaultRamStartAddress { get; internal set; } = 0x405000;

        public List<CustomAsmAreaConfig> Areas { get; } = new List<CustomAsmAreaConfig>();
        public int MaxLength { get; set; } = -1;
        public int Length { get; internal set; } = -1;
        public int RomStartAddress { get; set; }
        public int RamStartAddress { get; set; }

        public int GetRomStartAddress()
        {
            return RomStartAddress != -1 ? CustomAsmBankConfig.DefaultRomStartAddress : DefaultRomStartAddress;
        }

        public int GetRamStartAddress()
        {
            return RamStartAddress != -1 ? RamStartAddress : DefaultRamStartAddress;
        }
    }
}
