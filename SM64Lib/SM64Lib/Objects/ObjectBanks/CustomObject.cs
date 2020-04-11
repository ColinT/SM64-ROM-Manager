using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObject
    {
        public string Name { get; set; }
        public CustomObjectBehaviorProps BehaviorProps { get; private set; } = new CustomObjectBehaviorProps();
        public CustomObjectModelProps ModelProps { get; private set; } = new CustomObjectModelProps();

        public void TakeoverProperties(RomManager rommgr)
        {
            if (BehaviorProps.UseCollisionPointerOfModel && BehaviorProps.Behavior is object && ModelProps.Model is object)
            {
                BehaviorProps.Behavior.EnableCollisionPointer = true;

                var mdl = ModelProps.Model.FindModel();
                if (mdl is object)
                    BehaviorProps.Behavior.CollisionPointer = mdl.CollisionPointer;
            }
        }
    }
}
