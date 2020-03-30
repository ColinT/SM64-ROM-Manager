using SM64Lib.Data;

namespace SM64Lib.Behaviors.Script
{
    public class Behaviorscript : BehaviorscriptCommandCollection
    {

        public void Read(BinaryData data, int address)
        {
            bool ende = false;

            Close();
            Clear();
            data.Position = address;

            while (!ende)
            {
                // Get command infos
                var cmdType = (BehaviorscriptCommandTypes)data.ReadByte();
                int cmdLength = BehaviorscriptCommand.GetCommandLength(cmdType);
                bool isEndCmd = BehaviorscriptCommand.IsEndCommand(cmdType);

                // Reset position
                data.Position -= 1;

                // Read full command
                byte[] buf = new byte[cmdLength];
                data.Read(buf);

                // Create & add command
                Add(new BehaviorscriptCommand(buf));
            }
        }

        public void Write(BinaryData data, int address)
        {
            data.Position = address;

            foreach (BehaviorscriptCommand command in this)
            {
                var cmdLength = BehaviorscriptCommand.GetCommandLength(command.CommandType);
                if (command.Length != cmdLength)
                    command.SetLength(cmdLength);
                data.Write(command.ToArray());
            }
        }

    }
}