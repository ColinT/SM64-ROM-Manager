using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Behaviors
{
    public class BehaviorConfig
    {
        public int BankAddress { get; set; } = -1;
        public bool IsVanilla { get; set; } = false;
        public string Name { get; set; } = string.Empty;
    }
}
