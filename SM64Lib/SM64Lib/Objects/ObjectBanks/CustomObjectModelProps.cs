using Newtonsoft.Json;
using SM64Lib.Configuration;
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
        private CustomModelConfig _model;

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
                {
                    var mdl = Model.FindModel();
                    return mdl is object ? mdl.ModelID : _modelID;
                }
            }
            set
            {
                if (UseCustomModelID)
                    _modelID = value;
                else
                {
                    var mdl = Model.FindModel();
                    if (mdl is object)
                        mdl.ModelID = value;
                    else
                        _modelID = value;
                }
            }
        }

        [JsonIgnore]
        public CustomModelConfig Model
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
