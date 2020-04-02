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
        public int Address { get; private set; }
        public Behaviorscript Script { get; private set; }

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
            Address = address;
            CreateNewBehaviorscript();
            Script.Read(data, address);
            ParseScript();
        }
        
        public void Write(BinaryData data, int address)
        {
            Address = address;
            TakeoverSettingsToScript();
            Script.Write(data, address);
        }

        private void ParseScript()
        {
            //...
        }

        private void TakeoverSettingsToScript()
        {
            //...
        }

    }
}
