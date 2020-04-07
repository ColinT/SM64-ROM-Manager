using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Behaviors.Script
{
    public static class BehaviorscriptCommandFactory
    {
        public static BehaviorscriptCommand Build_x2E(int collisionPointer = -1)
        {
            var cmd = new BehaviorscriptCommand("2e 00 00 00 00 00 00 00");
            if (collisionPointer != -1)
                BehaviorscriptCommandFunctions.X2E.SetCollisionPointer(cmd, collisionPointer);
            return cmd;
        }
    }
}
