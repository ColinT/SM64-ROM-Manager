
using SM64Lib.Data;

namespace SM64Lib.Behaviors.Script
{
    public class Behaviorscript : BehaviorscriptCommandCollection
    {

        public void Read(BinaryData data, int address)
        {
            data.Position = address;
            //...
        }

        public void Write(BinaryData data, int address)
        {
            data.Position = address;

            foreach (BehaviorscriptCommand command in this)
                data.Write(command.ToArray());
        }

        public static int GetCommandLength(BehaviorscriptCommandTypes type)
        {
            switch (type)
            {
                //...
                default:
                    throw new System.Exception("Command type not found!");
            }
        }

    }
}