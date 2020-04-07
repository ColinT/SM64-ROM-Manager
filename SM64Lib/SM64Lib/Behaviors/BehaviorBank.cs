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

            BinaryData data = null;
            var lastBankID = (byte)0xff;

            void CloseDataIfZero()
            {
                if (data is BinaryRom)
                    data.Close();
            }

            foreach (var config in Config.BehaviorConfigs.OrderBy(n => n.BankAddress))
            {
                var bankID = (byte)(config.BankAddress >> 24);
                var bankOffset = config.BankAddress & 0xffffff;

                if (bankID != lastBankID)
                {
                    lastBankID = bankID;
                    CloseDataIfZero();
                    data = rommgr.GetSegBankData(bankID);

                    // Get correct bank
                    if (bankID == 0)
                        data = rommgr.GetBinaryRom(System.IO.FileAccess.Read);
                    else
                    {
                        var seg = rommgr.GetSegBank(bankID);
                        seg.ReadDataIfNull(rommgr);
                        data = new BinaryStreamData(seg.Data);
                    }
                }

                // Read & Add Behavior
                var behav = new Behavior(config);
                behav.Read(data, bankOffset);
                Behaviors.Add(behav);
            }

            CloseDataIfZero();
        }

        public void SaveBank(RomManager rommgr, int segStartAddress)
        {
            var usedConfigs = new List<BehaviorConfig>();
            var bankID = (byte)(segStartAddress >> 24);
            var data = rommgr.GetSegBankData(bankID);
            data.Position = segStartAddress & 0xffffff;

            // Save Behaviors to ROM
            foreach (var behav in Behaviors)
            {
                behav.Write(data, (int)data.Position);
                data.RoundUpPosition();
            }

            // Close/Save ROM
            if (data is BinaryRom)
                data.Close();
            else
            {
                var seg = rommgr.GetSegBank(bankID);
                seg.Length = General.HexRoundUp1((int)data.Position);
                seg.WriteData(rommgr);
            }

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
