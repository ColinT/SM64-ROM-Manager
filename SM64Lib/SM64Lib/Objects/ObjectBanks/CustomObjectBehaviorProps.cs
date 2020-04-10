using Newtonsoft.Json;
using SM64Lib.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectBehaviorProps
    {
        [JsonProperty(nameof(UseCustomAddress))]
        private bool _useCustomAddress = true;
        [JsonProperty(nameof(BehaviorAddress))]
        private int _behaviorAddress;
        [JsonProperty(nameof(Behavior))]
        private Behavior _behavior;

        public bool UseCollisionPointerOfModel { get; set; } = true;

        [JsonIgnore]
        public bool UseCustomAddress
        {
            get => _useCustomAddress;
            set
            {
                _useCustomAddress = value;
                if (value) Behavior = null;
            }
        }

        [JsonIgnore]
        public int BehaviorAddress
        {
            get
            {
                if (UseCustomAddress || Behavior == null)
                    return _behaviorAddress;
                else
                    return Behavior.Config.BankAddress;
            }
            set
            {
                if (UseCustomAddress)
                    _behaviorAddress = value;
                else
                    Behavior.Config.BankAddress = value;
            }
        }

        [JsonIgnore]
        public Behavior Behavior
        {
            get => _behavior;
            set
            {
                _behavior = value;
                UseCustomAddress = true;
            }
        }
    }
}
