using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SM64Lib.Behaviors;
using SM64Lib.Objects.ModelBanks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectCollection
    {
        public List<CustomObject> CustomObjects { get; } = new List<CustomObject>();

        public void TakeoverProperties(RomManager rommgr)
        {
            foreach (var cobj in CustomObjects)
                cobj.TakeoverProperties(rommgr);
        }

        public void Export(string filePath)
        {
            Export(filePath, CustomObjects.ToArray());
        }

        public static void Export(string filePath, CustomObject customObject)
        {
            Export(filePath, new CustomObject[] { customObject });
        }

        public static void Export(string filePath, CustomObject[] customObjects)
        {
            var export = new CustomObjectExport()
            {
                CustomObjects = customObjects,
                ExportDate = DateTime.UtcNow
            };

            foreach (var cobj in customObjects)
            {
                if (cobj.ModelProps is object)
                {
                    var mdl = cobj.ModelProps.Model.FindModel();
                    if (mdl is object)
                    {
                        export.CustomModels.Add(cobj.ModelProps.Model, mdl);
                    }
                }
            }

            var ser = JsonSerializer.CreateDefault();
            ser.PreserveReferencesHandling = PreserveReferencesHandling.All;
            ser.ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
            File.WriteAllText(filePath, JObject.FromObject(export, ser).ToString());
        }

        public static CustomObjectExport LoadImport(string filePath)
        {
            var ser = JsonSerializer.CreateDefault();
            ser.PreserveReferencesHandling = PreserveReferencesHandling.All;
            ser.ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
            return JObject.Parse(File.ReadAllText(filePath)).ToObject<CustomObjectExport>(ser);
        }

        public void Import(string filePath, CustomModelBank destModelBank, BehaviorBank destBehaviorBank)
        {
            Import(LoadImport(filePath), destModelBank, destBehaviorBank);
        }

        public void Import(CustomObjectExport export, CustomModelBank destModelBank, BehaviorBank destBehaviorBank)
        {
            foreach (var cobj in export.CustomObjects)
            {
                // Add Custom Model
                if (cobj.BehaviorProps.Behavior is object)
                {
                    if (cobj.BehaviorProps.Behavior.Config.IsVanilla)
                    {
                        var behav = destBehaviorBank.GetBehaviorByBankAddress(cobj.BehaviorProps.BehaviorAddress);
                        if (behav is object)
                            cobj.BehaviorProps.Behavior = behav;
                    }
                    else
                        destBehaviorBank.Behaviors.Add(cobj.BehaviorProps.Behavior);
                }

                // Add Custom Behavior
                if (cobj.ModelProps.Model is object && export.CustomModels.ContainsKey(cobj.ModelProps.Model))
                {
                    destModelBank.Models.Add(export.CustomModels[cobj.ModelProps.Model]);
                    destModelBank.NeedToSave = true;
                }

                // Add Custom Object
                CustomObjects.Add(cobj);
            }
        }
    }
}
