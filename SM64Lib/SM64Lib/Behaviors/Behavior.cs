using SM64Lib.Behaviors.Script;
using SM64Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Behaviors
{
    public class Behavior
    {
        public BehaviorConfig Config { get; private set; }
        public int BankAddress { get; internal set; }
        public Behaviorscript Script { get; private set; }
        public int CollisionPointer { get; set; }
        public bool EnableCollisionPointer { get; set; }
        public List<int> BehaviorAddressDestinations { get; set; } = new List<int>();
        public int FixedLength { get; set; } = -1;

        public Behavior()
        {
            CreateNewBehaviorscript();
        }

        public Behavior(BehaviorConfig config) : this()
        {
            Config = config;
        }

        public Behavior(BehaviorCreationTypes behaviorCreationType) : this()
        {
            Create(behaviorCreationType);
        }

        public void Create(BehaviorCreationTypes type)
        {
            CreateNewBehaviorscript();

            switch (type)
            {
                case BehaviorCreationTypes.SolidObject:
                    Script.Add(new BehaviorscriptCommand("00 09 00 00"));
                    Script.Add(new BehaviorscriptCommand("2a 00 00 00 00 00 00 00"));
                    Script.Add(new BehaviorscriptCommand("08 00 00 00"));
                    Script.Add(new BehaviorscriptCommand("0c 00 00 00 80 38 39 cc"));
                    Script.Add(new BehaviorscriptCommand("09 00 00 00"));
                    break;
            }
        }

        private void CreateNewBehaviorscript()
        {
            if (Script != null)
                Script.Close();
            Script = new Behaviorscript();
        }

        public void Read(BinaryData data, int address)
        {
            CreateNewBehaviorscript();
            Script.Read(data, address);
            if (Config.IsVanilla)
                FixedLength = (int)Script.Length;
            ParseScript();
        }
        
        public void Write(BinaryData data, int address)
        {
            if (!Config.IsVanilla)
                TakeoverSettingsToScript();

            var length = Script.Write(data, address);

            if (FixedLength != -1 && length != FixedLength)
                data.Position -= length - FixedLength;
        }

        private void ParseScript()
        {
            EnableCollisionPointer = false;

            foreach (BehaviorscriptCommand cmd in Script)
            {
                switch (cmd.CommandType)
                {
                    case BehaviorscriptCommandTypes.x2E_SetHurtbox:
                        CollisionPointer = BehaviorscriptCommandFunctions.X2E.GetCollisionPointer(cmd);
                        EnableCollisionPointer = true;
                        break;
                }
            }
        }

        private void TakeoverSettingsToScript()
        {
            // Update collision pointer
            AddUpdateRemoveCmd(
                BehaviorscriptCommandTypes.x2A_SetCollision,
                EnableCollisionPointer,
                () => BehaviorscriptCommandFactory.Build_x2E(CollisionPointer),
                (cmd) => BehaviorscriptCommandFunctions.X2E.SetCollisionPointer(cmd, CollisionPointer));
        }

        private void AddUpdateRemoveCmd(BehaviorscriptCommandTypes cmdType, bool conditionAddUpdate, Func<BehaviorscriptCommand> createCmd, Action<BehaviorscriptCommand> updateCmd)
        {
            var cmd = Script.FirstOfType(cmdType);
            if (cmd is object)
            {
                if (conditionAddUpdate)
                    updateCmd(cmd);
                else
                {
                    Script.Remove(cmd);
                    cmd.Close();
                }
            }
            else if (conditionAddUpdate)
            {
                cmd = createCmd();
                Script.Insert(1, cmd);
            }
        }

    }
}
