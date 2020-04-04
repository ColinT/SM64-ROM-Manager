using SM64Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Behaviors
{
    public class BehaviorBank
    {
        public BehaviorBankConfig Config { get; private set; }
        public List<Behavior> Behaviors { get; } = new List<Behavior>();

        public BehaviorBank(BehaviorBankConfig config)
        {
            Config = config;
        }

        public void ReadBank(RomManager rommgr)
        {
            // Clear current list
            Behaviors.Clear();

            foreach(var config in Config.BehaviorConfigs)
            {
                BinaryData data;
                var bankID = (byte)(config.BankAddress >> 24);
                var bankOffset = config.BankAddress & 0xffffff;

                // Get correct bank
                if (bankID == 0)
                    data = rommgr.GetBinaryRom(System.IO.FileAccess.Read);
                else
                {
                    var seg = rommgr.GetSegBank(bankID);
                    seg.ReadDataIfNull(rommgr);
                    data = new BinaryStreamData(seg.Data);
                }

                // Read & Add Behavior
                var behav = new Behavior(config);
                behav.Read(data, bankOffset);
                Behaviors.Add(behav);
            }
        }

        public void SaveBank()
        {
            var usedConfigs = new List<BehaviorConfig>();





            // Add new configs
            foreach (var newConfig in usedConfigs)
            {
                if (!Config.BehaviorConfigs.Contains(newConfig))
                    Config.BehaviorConfigs.Add(newConfig);
            }
            // Delete unused configs
            foreach (var oldConfig in Config.BehaviorConfigs)
            {
                if (!usedConfigs.Contains(oldConfig))
                    Config.BehaviorConfigs.Remove(oldConfig);
            }
        }
    }
}
