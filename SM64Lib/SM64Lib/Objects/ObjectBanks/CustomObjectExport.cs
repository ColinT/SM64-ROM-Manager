using SM64Lib.Configuration;
using SM64Lib.Objects.ModelBanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectExport
    {
        public CustomObject[] CustomObjects { get; set; }
        public DateTime ExportDate { get; set; }
        public Dictionary<CustomModelConfig, CustomModel> CustomModels { get; set; } = new Dictionary<CustomModelConfig, CustomModel>();
    }
}
