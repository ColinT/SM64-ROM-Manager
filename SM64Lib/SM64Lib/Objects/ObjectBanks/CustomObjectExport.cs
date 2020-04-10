using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectExport
    {
        public string Comments { get; set; }
        public CustomObject[] CustomObjects { get; set; }
        public DateTime ExportDate { get; set; }
    }
}
