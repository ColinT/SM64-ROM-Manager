using Newtonsoft.Json;
using SM64Lib.Objects.ModelBanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectModelProps
    {
        [JsonProperty(nameof(UseCustomModelID))]
        private bool _useCustomModelID = true;
        [JsonProperty(nameof(ModelID))]
        private byte _modelID;
        [JsonProperty(nameof(Model))]
        private CustomModel _model;

        [JsonIgnore]
        public bool UseCustomModelID
        {
            get => _useCustomModelID;
            set
            {
                _useCustomModelID = value;
                if (value) Model = null;
            }
        }

        [JsonIgnore]
        public byte ModelID
        {
            get
            {
                if (UseCustomModelID || Model == null)
                    return _modelID;
                else
                    return Model.ModelID;
            }
            set
            {
                if (UseCustomModelID)
                    _modelID = value;
                else
                    Model.ModelID = value;
            }
        }

        [JsonIgnore]
        public CustomModel Model
        {
            get => _model;
            set
            {
                _model = value;
                UseCustomModelID = false;
            }
        }
    }
}
