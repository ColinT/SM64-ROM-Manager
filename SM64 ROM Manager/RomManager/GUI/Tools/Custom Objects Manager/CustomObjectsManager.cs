using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.WindowsAPICodePack.Dialogs;
using SM64Lib;
using SM64Lib.Objects.ObjectBanks;
using static SM64Lib.TextValueConverter.TextValueConverter;
using Z.Collections.Extensions;
using System.Linq;
using System.IO;
using Timer = System.Timers.Timer;

namespace SM64_ROM_Manager
{
    public partial class CustomObjectsManager : OfficeForm
    {
        // C o n s t a n t s

        private const string FILTER_CUSTOM_OBJECT_NAMES = "Custom Objects (*.rmobj)";
        private const string FILTER_CUSTOM_OBJECT_EXTENSIONS = "*.rmobj";

        // F i e l d s

        private readonly CustomObjectCollection customObjectCollection;
        private readonly RomManager rommgr;
        private CustomObject customObject = null;
        private bool isLoadingProps = false;
        private Timer Timer_PropsChanged;

        // C o n s t r u c t o r

        public CustomObjectsManager(CustomObjectCollection collection, RomManager rommgr)
        {
            this.rommgr = rommgr;
            customObjectCollection = collection;

            // Components
            InitializeComponent();
            UpdateAmbientColors();
            layoutControl1.Enabled = false;

            // Props-Timer
            Timer_PropsChanged = new Timer(1000) { SynchronizingObject = this, AutoReset = false };
            Timer_PropsChanged.Elapsed += Timer_PropsChanged_Elapsed;
        }

        // T i m e r   E v e n t s

        private void Timer_PropsChanged_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            UpdateNode(customObject);
        }

        // F e a t u r e s

        private void LoadObjects()
        {
            AdvTree_Objs.BeginUpdate();
            AdvTree_Objs.Nodes.Clear();

            foreach (var cobj in customObjectCollection.CustomObjects)
                AdvTree_Objs.Nodes.Add(GetNode(cobj));

            AdvTree_Objs.EndUpdate();
        }

        private Node GetNode(CustomObject cobj)
        {
            var n = new Node()
            {
                Tag = cobj
            };
            n.Cells.Add(new Cell());
            n.Cells.Add(new Cell());
            UpdateNode(n);
            return n;
        }

        private void UpdateNode(Node n)
        {
            if (n?.Tag is CustomObject)
            {
                var cobj = (CustomObject)n.Tag;
                n.Text = cobj.Name;
                n.Cells[1].Text = TextFromValue(cobj.ModelProps.ModelID);
                n.Cells[2].Text = TextFromValue(cobj.BehaviorProps.BehaviorAddress);
            }
        }

        private void UpdateNode(CustomObject cobj)
        {
            UpdateNode(FindNode(cobj));
        }

        private Node FindNode(CustomObject cobj)
        {
            Node n = null;

            foreach (Node nn in AdvTree_Objs.Nodes)
            {
                if (n == null && nn.Tag == cobj)
                    n = nn;
            }

            return n;
        }

        private void SelectNode(Node n)
        {
            AdvTree_Objs.SelectedNode = n;
            n?.EnsureVisible();
        }

        private void LoadObjectProps()
        {
            if (customObject is object)
            {
                isLoadingProps = true;

                // General
                TextBoxX_Name.Text = customObject.Name;
                TextBoxX_Description.Text = customObject.Description;
                CheckBoxX_UseColPtrForBehav.Checked = customObject.BehaviorProps.UseCollisionPointerOfModel;

                // Behavior Props
                if (customObject.BehaviorProps.UseCustomAddress)
                {
                    CheckBoxX_BehavCustom.Checked = true;
                    TextBoxX_BehavAddr.Text = TextFromValue(customObject.BehaviorProps.BehaviorAddress);
                }
                else
                    CheckBoxX_BehavBank.Checked = true;

                // Model Props
                if (customObject.ModelProps.UseCustomModelID)
                {
                    if (customObject.ModelProps.ModelID == 0)
                        CheckBoxX_NoModel.Checked = true;
                    else
                        CheckBoxX_CustomModelID.Checked = true;
                    TextBoxX_ModelID.Text = TextFromValue(customObject.ModelProps.ModelID);
                }
                else
                    CheckBoxX_CustomModel.Checked = true;

                isLoadingProps = false;
            }
        }

        private void SaveObjectProps()
        {
            if (!isLoadingProps && customObject is object)
            {
                Timer_PropsChanged.Stop();

                customObject.Name = TextBoxX_Name.Text.Trim();
                customObject.Description = TextBoxX_Description.Text.Trim();
                customObject.BehaviorProps.UseCollisionPointerOfModel = CheckBoxX_UseColPtrForBehav.Checked;

                if (CheckBoxX_BehavCustom.Checked)
                    customObject.BehaviorProps.BehaviorAddress = ValueFromText(TextBoxX_BehavAddr.Text);

                if (CheckBoxX_NoModel.Checked)
                    customObject.ModelProps.ModelID = 0;
                else if (CheckBoxX_CustomModelID.Checked)
                    customObject.ModelProps.ModelID = Conversions.ToByte(ValueFromText(TextBoxX_ModelID.Text));

                Timer_PropsChanged.Start();
            }
        }

        private IEnumerable<CustomObject> GetSelectedCustomObjects()
        {
            var cobjs = new List<CustomObject>();

            foreach (Node n in AdvTree_Objs.SelectedNodes)
            {
                if (n.Tag is CustomObject)
                    cobjs.Add((CustomObject)n.Tag);
            }

            return cobjs;
        }

        private void ExportObjects(string filePath, bool multiExport)
        {
            if (multiExport)
            {
                var objs = GetSelectedCustomObjects();
                foreach (var obj in objs)
                {
                    var myFilePath = Path.Combine(filePath, obj.Name + ".rmobj");
                    CustomObjectCollection.Export(myFilePath, obj);
                }
            }
            else
            {
                var objs = GetSelectedCustomObjects();
                CustomObjectCollection.Export(filePath, objs.ToArray());
            }
        }

        private bool IsMultiselect()
        {
            return AdvTree_Objs.SelectedNodes.Count > 1;
        }

        private void ImportObjects(string[] filePaths)
        {

        }

        // G u i

        private void ButtonItem_NewObject_Click(object sender, EventArgs e)
        {
            var obj = new CustomObject
            {
                Name = "New Object"
            };
            customObjectCollection.CustomObjects.Add(obj);

            var n = GetNode(obj);
            AdvTree_Objs.Nodes.Add(n);
            SelectNode(n);
        }

        private void ButtonItem_ImportFromFile_Click(object sender, EventArgs e)
        {
            var ofd_SM64RM_ExportCustomObjectToFile = new OpenFileDialog
            {
                Filter = $"{FILTER_CUSTOM_OBJECT_NAMES} ({FILTER_CUSTOM_OBJECT_EXTENSIONS})|{FILTER_CUSTOM_OBJECT_EXTENSIONS}",
                Multiselect = true
            };

            if (ofd_SM64RM_ExportCustomObjectToFile.ShowDialog() == DialogResult.OK)
                ImportObjects(ofd_SM64RM_ExportCustomObjectToFile.FileNames);
        }

        private void ButtonItem_ImportFromDatabase_Click(object sender, EventArgs e)
        {

        }

        private void ButtonItem_DeleteObject_Click(object sender, EventArgs e)
        {
            var n = FindNode(customObject);

            if (n is object)
                n.Remove();

            customObjectCollection.CustomObjects.RemoveIfContains(customObject);

            SelectNode(null);
        }

        private void ButtonItem_ExportToFile_Click(object sender, EventArgs e)
        {
            var isMultiselect = IsMultiselect();
            CommonFileDialog sfd_SM64RM_ExportCustomObjectToFile;

            if (isMultiselect && MessageBoxEx.Show(this, "You are going to export multiple custom objects. Do you want to save all objects to one single file (Yes) or do you want to save every single object to one file (No)?", "Export Custom Objects", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                sfd_SM64RM_ExportCustomObjectToFile = new CommonOpenFileDialog() { IsFolderPicker = true };
            else
            {
                sfd_SM64RM_ExportCustomObjectToFile = new CommonSaveFileDialog();
                sfd_SM64RM_ExportCustomObjectToFile.Filters.Add(new CommonFileDialogFilter(FILTER_CUSTOM_OBJECT_NAMES, FILTER_CUSTOM_OBJECT_EXTENSIONS));
            }

            if (sfd_SM64RM_ExportCustomObjectToFile.ShowDialog(Handle) == CommonFileDialogResult.Ok)
                ExportObjects(sfd_SM64RM_ExportCustomObjectToFile.FileName, isMultiselect);
        }

        private void ButtonItem_UploadToDatabase_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxX_Name_TextChanged(object sender, EventArgs e)
        {
            SaveObjectProps();
        }

        private void TextBoxX_BehavAddr_TextChanged(object sender, EventArgs e)
        {
            SaveObjectProps();
        }

        private void ButtonX_SelectFromBehavBank_Click(object sender, EventArgs e)
        {
            var frm = new CustomBehaviorSelector(rommgr)
            {
                Behavior = customObject.BehaviorProps.Behavior
            };

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                customObject.BehaviorProps.Behavior = frm.Behavior;
                LoadObjectProps();
            }
        }

        private void TextBoxX_ModelID_TextChanged(object sender, EventArgs e)
        {
            SaveObjectProps();
        }

        private void ButtonX_SelectCustomModelFromBank_Click(object sender, EventArgs e)
        {
            var frm = new CustomModelSelector(rommgr)
            {
                Model = customObject.ModelProps.Model
            };

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                customObject.ModelProps.Model = frm.Model;
                LoadObjectProps();
            }
        }

        private void CheckBoxX_BehavCustom_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxX_BehavAddr.Enabled = CheckBoxX_BehavCustom.Checked;

            if (!isLoadingProps && customObject is object && CheckBoxX_BehavCustom.Checked)
            {
                customObject.BehaviorProps.UseCustomAddress = true;
                LoadObjectProps();
            }
        }

        private void CheckBoxX_NoModel_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = CheckBoxX_NoModel.Checked;

            if (isChecked)
            {
                CheckBoxX_CustomModel.Checked = false;
                CheckBoxX_CustomModelID.Checked = false;
            }

            if (!isLoadingProps && customObject is object && isChecked)
            {
                customObject.ModelProps.UseCustomModelID = true;
                customObject.ModelProps.ModelID = 0;
            }
        }

        private void CheckBoxX_CustomModelID_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = CheckBoxX_CustomModelID.Checked;
            TextBoxX_ModelID.Enabled = isChecked;

            if (isChecked)
            {
                CheckBoxX_CustomModel.Checked = false;
                CheckBoxX_NoModel.Checked = false;
            }

            if (!isLoadingProps && customObject is object && isChecked)
            {
                customObject.ModelProps.UseCustomModelID = true;
            }
        }

        private void CheckBoxX_UseColPtrForBehav_CheckedChanged(object sender, EventArgs e)
        {
            SaveObjectProps();
        }

        private void AdvTree_Objs_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            customObject = e.Node?.Tag as CustomObject;

            var isObject = customObject != null;
            layoutControl1.Enabled = isObject;
            buttonItem_Export.Enabled = isObject;
            ButtonItem_DeleteObject.Enabled = isObject;
        }

        private void CheckBoxX_CustomModel_Click(object sender, EventArgs e)
        {
            ButtonX_SelectCustomModelFromBank.PerformClick();
        }

        private void CheckBoxX_BehavBank_Click(object sender, EventArgs e)
        {
            ButtonX_SelectFromBehavBank.PerformClick();
        }

        private void TextBoxX_Description_TextChanged(object sender, EventArgs e)
        {
            SaveObjectProps();
        }
    }
}