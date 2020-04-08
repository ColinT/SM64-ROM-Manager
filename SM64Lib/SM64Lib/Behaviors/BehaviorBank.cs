﻿using SM64Lib.Data;
using SM64Lib.SegmentedBanking;
using System;
using System.Collections.Generic;
using System.IO;
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

        public void ReadBank(SegmentedBank seg, int offset)
        {
            ReadBank(seg, offset, false);
        }

        public void ReadVanillaBank(SegmentedBank seg)
        {
            ReadBank(seg, 0, true);
        }

        private void ReadBank(SegmentedBank seg, int offset, bool isVanilla)
        {
            var data = new BinaryStreamData(seg.Data);
            data.Position = offset;
            ReadBank(data, isVanilla);
        }

        public void ReadBank(BinaryData data)
        {
            ReadBank(data, false);
        }

        private void ReadBank(BinaryData data, bool isVanilla)
        {
            // Clear current list
            Behaviors.Clear();

            // Read Behaviors
            foreach (var config in Config.BehaviorConfigs.OrderBy(n => n.BankAddress))
            {
                var bankOffset = config.BankAddress & 0xffffff;
                var behav = new Behavior(config)
                {
                    BankAddress = config.BankAddress
                };
                behav.Read(data, bankOffset);
                Behaviors.Add(behav);
            }
        }

        public SegmentedBank WriteToSeg(byte bankID, int offset, RomManager rommgr)
        {
            var segStream = new MemoryStream();
            var seg = new SegmentedBank(bankID, segStream);
            int lastPos = WriteToSeg(seg, offset, rommgr);
            seg.Length = lastPos;
            return seg;
        }

        public int WriteToSeg(SegmentedBank seg, int offset, RomManager rommgr)
        {
            var usedConfigs = new List<BehaviorConfig>();
            var addressUpdates = new Dictionary<int, int>();
            var segStartAddress = seg.BankAddress | offset;
            var data = new BinaryStreamData(seg.Data);
            data.Position = offset;

            if (Behaviors.Any())
            {
                // Save Behaviors to ROM
                foreach (var behav in Behaviors)
                {
                    var address = (int)data.Position;
                    var newBankAddress = (int)data.Position - offset + segStartAddress;
                    if (newBankAddress != behav.Config.BankAddress)
                    {
                        addressUpdates.Add(behav.Config.BankAddress, newBankAddress);
                        behav.Config.BankAddress = newBankAddress;
                        behav.BankAddress = newBankAddress;
                    }
                    behav.Write(data, (int)data.Position);
                    data.RoundUpPosition();
                }

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
            if (Behaviors.Any() && rommgr is object)
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

            return (int)data.Position;
        }

        public void WriteBehaviorAddresss(RomManager rommgr)
        {
            var data = rommgr.GetBinaryRom(FileAccess.ReadWrite);
            WriteBehaviorAddresss(data);
            data.Close();
        }

        public void WriteBehaviorAddresss(BinaryData data)
        {
            if (Behaviors.Any())
            {
                foreach (var behav in Behaviors)
                {
                    foreach (var dest in behav.BehaviorAddressDestinations)
                    {
                        data.Position = dest;
                        data.Write(behav.BankAddress);
                    }
                }
            }
        }
    }
}
