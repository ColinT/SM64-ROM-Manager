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

        public void Export(string filePath, string comments)
        {
            Export(filePath, CustomObjects.ToArray(), comments);
        }

        public static void Export(string filePath, CustomObject customObject, string comments)
        {
            Export(filePath, new CustomObject[] { customObject }, comments);
        }

        public static void Export(string filePath, CustomObject[] customObjects, string comments)
        {
            var export = new CustomObjectExport()
            {
                Comments = comments,
                CustomObjects = customObjects,
                ExportDate = DateTime.UtcNow
            };
            File.WriteAllText(filePath, JObject.FromObject(export).ToString());
        }

        public static CustomObjectExport LoadImport(string filePath)
        {
            return JObject.Parse(File.ReadAllText(filePath)).ToObject<CustomObjectExport>();
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
                if (cobj.ModelProps.Model is object)
                {
                    destModelBank.Models.Add(cobj.ModelProps.Model);
                    destModelBank.NeedToSave = true;
                }

                // Add Custom Object
                CustomObjects.Add(cobj);
            }
        }
    }
}
