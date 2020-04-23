﻿using Newtonsoft.Json;
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
        public string Description { get; set; }
        public CustomObjectBehaviorProps BehaviorProps { get; private set; } = new CustomObjectBehaviorProps();
        public CustomObjectModelProps ModelProps { get; private set; } = new CustomObjectModelProps();

        public void TakeoverProperties(RomManager rommgr)
        {
            var behav = BehaviorProps.Behavior?.FindBehavior();
            if (BehaviorProps.UseCollisionPointerOfModel && BehaviorProps.Behavior is object && (!BehaviorProps.Behavior.IsVanilla || behav.EnableCollisionPointer) && ModelProps.Model is object)
            {
                var mdl = ModelProps.Model.FindModel();

                if (mdl?.Model?.Collision is object && mdl.CollisionPointer != -1)
                {
                    behav.CollisionPointer = mdl.CollisionPointer;
                    behav.EnableCollisionPointer = true;
                }
            }
        }
    }
}
