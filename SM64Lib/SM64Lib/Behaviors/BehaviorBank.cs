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

            foreach (var config in Config.BehaviorConfigs.OrderBy(n => n.BankAddress))
            {
                var bankID = (byte)(config.BankAddress >> 24);
                var bankOffset = config.BankAddress & 0xffffff;

                if (bankID != lastBankID)
                {
                    // Get correct bank
                    lastBankID = bankID;
                    data = rommgr.GetSegBankData(bankID);
                }

                // Read & Add Behavior
                var behav = new Behavior(config)
                {
                    BankAddress = config.BankAddress
                };
                behav.Read(data, bankOffset);
                Behaviors.Add(behav);
            }
        }

        public void SaveBank(RomManager rommgr, int segStartAddress)
        {
            var usedConfigs = new List<BehaviorConfig>();
            var addressUpdates = new Dictionary<int, int>();

            if (Behaviors.Any())
            {
                var bankID = (byte)(segStartAddress >> 24);
                var segStartOffset = segStartAddress & 0xffffff;
                var data = rommgr.GetSegBankData(bankID);
                data.Position = segStartOffset;

                // Save Behaviors to ROM
                foreach (var behav in Behaviors)
                {
                    var address = (int)data.Position;
                    behav.Config.BankAddress = (int)data.Position - segStartOffset + segStartAddress; //(bankID << 24) | address;
                    behav.BankAddress = behav.Config.BankAddress;
                    behav.Write(data, (int)data.Position);
                    data.RoundUpPosition();
                }

                // Save ROM
                var seg = rommgr.GetSegBank(bankID);
                seg.Length = General.HexRoundUp1((int)data.Position);
                seg.WriteData(rommgr);

                // Add new configs
                foreach (var newConfig in usedConfigs)
                {
                    if (!Config.BehaviorConfigs.Contains(newConfig))
                        Config.BehaviorConfigs.Add(newConfig);
                }
            }

            // Delete unused configs
            foreach (var oldConfig in Config.BehaviorConfigs)
            {
                if (!usedConfigs.Contains(oldConfig))
                    Config.BehaviorConfigs.Remove(oldConfig);
            }

            // Update addresses
            if (Behaviors.Any())
            {
                foreach (var lvl in rommgr.Levels)
                {
                    foreach (var area in lvl.Areas)
                    {
                        foreach (var obj in area.Objects)
                        {
                            var behavAddr = Levels.Script.Commands.clNormal3DObject.GetSegBehaviorAddr(obj);
                            foreach (var kvp in addressUpdates)
                            {
                                if (behavAddr == kvp.Key)
                                    Levels.Script.Commands.clNormal3DObject.SetSegBehaviorAddr(obj, (uint)kvp.Value);
                            }
                        }
                    }
                }
            }
        }

        public void WriteBehaviorAddresss(RomManager rommgr)
        {
            var data = rommgr.GetBinaryRom(System.IO.FileAccess.ReadWrite);

            if (Behaviors.Any())
            {
                foreach (var behav in Behaviors)
                {
                    foreach (var dest in behav.BehaviorAddressDestinations)
                    {
                        data.Position = dest;
                        data.Write(behav.Address);
                    }
                }
            }

            data.Close();
        }
    }
}
