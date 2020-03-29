
namespace SM64Lib.Behaviors.Script
{
    public class BehaviorscriptCommand : SM64Lib.Script.BaseCommand<BehaviorscriptCommandTypes>
    {

        public override BehaviorscriptCommandTypes CommandType
        {
            get
            {
                Position = 0;
                return (BehaviorscriptCommandTypes)ReadByte();
            }

            set
            {
                Position = 0;
                WriteByte((byte)value);
            }
        }

        public BehaviorscriptCommand() : base()
        {
        }

        public BehaviorscriptCommand(string cmd) : base(cmd, true)
        {
        }

    }
}