using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class ModelBankManager : DevComponents.DotNetBar.OfficeForm
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelBankManager));
            ItemListBox1 = new Publics.Controls.ItemListBox();
            ButtonX_CreateNewObject = new DevComponents.DotNetBar.ButtonX();
            ButtonX_CreateNewObject.Click += new EventHandler(ButtonX1_Click);
            ButtonX_RemoveObject = new DevComponents.DotNetBar.ButtonX();
            ButtonX_RemoveObject.Click += new EventHandler(ButtonItem_RemoveObject_Click);
            TextBoxX_ModelID = new DevComponents.DotNetBar.Controls.TextBoxX();
            TextBoxX_ModelID.TextChanged += new EventHandler(TextBoxX_ModelID_TextChanged);
            ButtonX_ImportModel = new DevComponents.DotNetBar.ButtonX();
            ButtonX_ImportModel.Click += new EventHandler(ButtonItem_ImportModell_Click);
            Panel1 = new Panel();
            LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            TextBoxX_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            TextBoxX_Name.TextChanged += new EventHandler(TextBoxX_Name_TextChanged);
            LabelX_CollisionPointerDestinationsCount = new DevComponents.DotNetBar.LabelX();
            ButtonX_EditCollisionPointerDestinations = new DevComponents.DotNetBar.ButtonX();
            ButtonX_EditCollisionPointerDestinations.Click += new EventHandler(ButtonX_EditCollisionPointerDestinations_Click);
            LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutGroup_ModelInfo = new DevComponents.DotNetBar.Layout.LayoutGroup();
            LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutGroup_CollisionPointerDestinations = new DevComponents.DotNetBar.Layout.LayoutGroup();
            LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            CM_Object = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_ImportModell = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_ImportModell.Click += new EventHandler(ButtonItem_ImportModell_Click);
            ButtonItem_ImportVisualMap = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_ImportVisualMap.Click += new EventHandler(ButtonItem_ImportVisualMap_Click);
            ButtonItem_ImportCollision = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_ImportCollision.Click += new EventHandler(ButtonItem_ImportCollision_Click);
            ButtonItem_RemoveCollision = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_RemoveCollision.Click += new EventHandler(ButtonItem_RemoveCollision_Click);
            ButtonItem_ShowVisualMap = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_ShowVisualMap.Click += new EventHandler(ButtonItem_ShowVisualMap_Click);
            ButtonItem_ShowCollision = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_ShowCollision.Click += new EventHandler(ButtonItem_ShowCollision_Click);
            ButtonItem_CopyCollisionPointer = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_CopyCollisionPointer.Click += new EventHandler(ButtonItem_CopyCollisionPointer_Click);
            ButtonItem_RemoveObject = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem_RemoveObject.Click += new EventHandler(ButtonItem_RemoveObject_Click);
            Panel1.SuspendLayout();
            LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContextMenuBar1).BeginInit();
            SuspendLayout();
            // 
            // ItemListBox1
            // 
            // 
            // 
            // 
            ItemListBox1.BackgroundStyle.Class = "ItemPanel";
            ItemListBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ItemListBox1.ContainerControlProcessDialogKey = true;
            resources.ApplyResources(ItemListBox1, "ItemListBox1");
            ItemListBox1.DragDropSupport = true;
            ItemListBox1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            ItemListBox1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            ItemListBox1.Name = "ItemListBox1";
            ItemListBox1.ReserveLeftSpace = false;
            ItemListBox1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_CreateNewObject
            // 
            ButtonX_CreateNewObject.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(ButtonX_CreateNewObject, "ButtonX_CreateNewObject");
            ButtonX_CreateNewObject.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            ButtonX_CreateNewObject.FocusCuesEnabled = false;
            ButtonX_CreateNewObject.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            ButtonX_CreateNewObject.Name = "ButtonX_CreateNewObject";
            ButtonX_CreateNewObject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ButtonX_CreateNewObject.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            ButtonX_CreateNewObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            ButtonX_CreateNewObject.SymbolSize = 12.0F;
            // 
            // ButtonX_RemoveObject
            // 
            ButtonX_RemoveObject.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(ButtonX_RemoveObject, "ButtonX_RemoveObject");
            ButtonX_RemoveObject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ButtonX_RemoveObject.FocusCuesEnabled = false;
            ButtonX_RemoveObject.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            ButtonX_RemoveObject.Name = "ButtonX_RemoveObject";
            ButtonX_RemoveObject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ButtonX_RemoveObject.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            ButtonX_RemoveObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            ButtonX_RemoveObject.SymbolSize = 12.0F;
            // 
            // TextBoxX_ModelID
            // 
            TextBoxX_ModelID.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_ModelID.Border.Class = "TextBoxBorder";
            TextBoxX_ModelID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_ModelID.DisabledBackColor = Color.White;
            TextBoxX_ModelID.ForeColor = Color.Black;
            resources.ApplyResources(TextBoxX_ModelID, "TextBoxX_ModelID");
            TextBoxX_ModelID.Name = "TextBoxX_ModelID";
            TextBoxX_ModelID.PreventEnterBeep = true;
            // 
            // ButtonX_ImportModel
            // 
            ButtonX_ImportModel.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(ButtonX_ImportModel, "ButtonX_ImportModel");
            ButtonX_ImportModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ButtonX_ImportModel.FocusCuesEnabled = false;
            ButtonX_ImportModel.Image = My.Resources.MyIcons.icons8_import_16px;
            ButtonX_ImportModel.Name = "ButtonX_ImportModel";
            ButtonX_ImportModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Transparent;
            Panel1.Controls.Add(ButtonX_CreateNewObject);
            Panel1.Controls.Add(ItemListBox1);
            Panel1.Controls.Add(LayoutControl1);
            resources.ApplyResources(Panel1, "Panel1");
            Panel1.Name = "Panel1";
            // 
            // LayoutControl1
            // 
            LayoutControl1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            LayoutControl1.Controls.Add(TextBoxX_ModelID);
            LayoutControl1.Controls.Add(TextBoxX_Name);
            LayoutControl1.Controls.Add(ButtonX_ImportModel);
            LayoutControl1.Controls.Add(ButtonX_RemoveObject);
            LayoutControl1.Controls.Add(LabelX_CollisionPointerDestinationsCount);
            LayoutControl1.Controls.Add(ButtonX_EditCollisionPointerDestinations);
            resources.ApplyResources(LayoutControl1, "LayoutControl1");
            LayoutControl1.ForeColor = Color.Black;
            LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { LayoutControlItem3, LayoutControlItem4, LayoutGroup_ModelInfo, LayoutGroup_CollisionPointerDestinations });
            // 
            // TextBoxX_Name
            // 
            TextBoxX_Name.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_Name.Border.Class = "TextBoxBorder";
            TextBoxX_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_Name.DisabledBackColor = Color.White;
            TextBoxX_Name.ForeColor = Color.Black;
            resources.ApplyResources(TextBoxX_Name, "TextBoxX_Name");
            TextBoxX_Name.Name = "TextBoxX_Name";
            TextBoxX_Name.PreventEnterBeep = true;
            // 
            // LabelX_CollisionPointerDestinationsCount
            // 
            // 
            // 
            // 
            LabelX_CollisionPointerDestinationsCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(LabelX_CollisionPointerDestinationsCount, "LabelX_CollisionPointerDestinationsCount");
            LabelX_CollisionPointerDestinationsCount.Name = "LabelX_CollisionPointerDestinationsCount";
            LabelX_CollisionPointerDestinationsCount.TextAlignment = StringAlignment.Center;
            // 
            // ButtonX_EditCollisionPointerDestinations
            // 
            ButtonX_EditCollisionPointerDestinations.AccessibleRole = AccessibleRole.PushButton;
            ButtonX_EditCollisionPointerDestinations.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ButtonX_EditCollisionPointerDestinations.Image = My.Resources.MyIcons.icons8_edit_16px;
            resources.ApplyResources(ButtonX_EditCollisionPointerDestinations, "ButtonX_EditCollisionPointerDestinations");
            ButtonX_EditCollisionPointerDestinations.Name = "ButtonX_EditCollisionPointerDestinations";
            ButtonX_EditCollisionPointerDestinations.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LayoutControlItem3
            // 
            LayoutControlItem3.Control = ButtonX_ImportModel;
            LayoutControlItem3.Height = 31;
            LayoutControlItem3.MinSize = new Size(32, 20);
            LayoutControlItem3.Name = "LayoutControlItem3";
            LayoutControlItem3.Width = 99;
            LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            LayoutControlItem4.Control = ButtonX_RemoveObject;
            LayoutControlItem4.Height = 31;
            LayoutControlItem4.MinSize = new Size(32, 20);
            LayoutControlItem4.Name = "LayoutControlItem4";
            LayoutControlItem4.Width = 31;
            // 
            // LayoutGroup_ModelInfo
            // 
            LayoutGroup_ModelInfo.Height = 57;
            LayoutGroup_ModelInfo.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { LayoutControlItem2, LayoutControlItem1 });
            LayoutGroup_ModelInfo.MinSize = new Size(120, 32);
            LayoutGroup_ModelInfo.Name = "LayoutGroup_ModelInfo";
            LayoutGroup_ModelInfo.Padding = new Padding(0);
            LayoutGroup_ModelInfo.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            LayoutGroup_ModelInfo.Width = 100;
            LayoutGroup_ModelInfo.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            LayoutControlItem2.Control = TextBoxX_Name;
            LayoutControlItem2.Height = 28;
            LayoutControlItem2.MinSize = new Size(120, 0);
            LayoutControlItem2.Name = "LayoutControlItem2";
            resources.ApplyResources(LayoutControlItem2, "LayoutControlItem2");
            LayoutControlItem2.Width = 100;
            LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem1
            // 
            LayoutControlItem1.Control = TextBoxX_ModelID;
            LayoutControlItem1.Height = 28;
            LayoutControlItem1.MinSize = new Size(120, 0);
            LayoutControlItem1.Name = "LayoutControlItem1";
            resources.ApplyResources(LayoutControlItem1, "LayoutControlItem1");
            LayoutControlItem1.Width = 100;
            LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutGroup_CollisionPointerDestinations
            // 
            LayoutGroup_CollisionPointerDestinations.Height = 35;
            LayoutGroup_CollisionPointerDestinations.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { LayoutControlItem5, LayoutControlItem6 });
            LayoutGroup_CollisionPointerDestinations.MinSize = new Size(120, 32);
            LayoutGroup_CollisionPointerDestinations.Name = "LayoutGroup_CollisionPointerDestinations";
            LayoutGroup_CollisionPointerDestinations.Padding = new Padding(0);
            LayoutGroup_CollisionPointerDestinations.TextPadding = new Padding(4, 0, 0, 0);
            LayoutGroup_CollisionPointerDestinations.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            LayoutGroup_CollisionPointerDestinations.Width = 100;
            LayoutGroup_CollisionPointerDestinations.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            LayoutControlItem5.Control = LabelX_CollisionPointerDestinationsCount;
            LayoutControlItem5.Height = 31;
            LayoutControlItem5.MinSize = new Size(64, 18);
            LayoutControlItem5.Name = "LayoutControlItem5";
            resources.ApplyResources(LayoutControlItem5, "LayoutControlItem5");
            LayoutControlItem5.Width = 99;
            LayoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem6
            // 
            LayoutControlItem6.Control = ButtonX_EditCollisionPointerDestinations;
            LayoutControlItem6.Height = 31;
            LayoutControlItem6.MinSize = new Size(32, 20);
            LayoutControlItem6.Name = "LayoutControlItem6";
            LayoutControlItem6.Width = 90;
            // 
            // ContextMenuBar1
            // 
            ContextMenuBar1.AntiAlias = true;
            resources.ApplyResources(ContextMenuBar1, "ContextMenuBar1");
            ContextMenuBar1.IsMaximized = false;
            ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { CM_Object });
            ContextMenuBar1.Name = "ContextMenuBar1";
            ContextMenuBar1.Stretch = true;
            ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ContextMenuBar1.TabStop = false;
            // 
            // CM_Object
            // 
            CM_Object.AutoExpandOnClick = true;
            CM_Object.Name = "CM_Object";
            CM_Object.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { ButtonItem_ImportModell, ButtonItem_ImportVisualMap, ButtonItem_ImportCollision, ButtonItem_RemoveCollision, ButtonItem_ShowVisualMap, ButtonItem_ShowCollision, ButtonItem_CopyCollisionPointer, ButtonItem_RemoveObject });
            resources.ApplyResources(CM_Object, "CM_Object");
            // 
            // ButtonItem_ImportModell
            // 
            ButtonItem_ImportModell.Image = My.Resources.MyIcons.icons8_import_16px;
            ButtonItem_ImportModell.Name = "ButtonItem_ImportModell";
            resources.ApplyResources(ButtonItem_ImportModell, "ButtonItem_ImportModell");
            // 
            // ButtonItem_ImportVisualMap
            // 
            ButtonItem_ImportVisualMap.Image = (Image)resources.GetObject("ButtonItem_ImportVisualMap.Image");
            ButtonItem_ImportVisualMap.Name = "ButtonItem_ImportVisualMap";
            resources.ApplyResources(ButtonItem_ImportVisualMap, "ButtonItem_ImportVisualMap");
            // 
            // ButtonItem_ImportCollision
            // 
            ButtonItem_ImportCollision.Image = (Image)resources.GetObject("ButtonItem_ImportCollision.Image");
            ButtonItem_ImportCollision.Name = "ButtonItem_ImportCollision";
            resources.ApplyResources(ButtonItem_ImportCollision, "ButtonItem_ImportCollision");
            // 
            // ButtonItem_RemoveCollision
            // 
            ButtonItem_RemoveCollision.Image = My.Resources.MyIcons.icons8_delete_2_16px;
            ButtonItem_RemoveCollision.Name = "ButtonItem_RemoveCollision";
            resources.ApplyResources(ButtonItem_RemoveCollision, "ButtonItem_RemoveCollision");
            // 
            // ButtonItem_ShowVisualMap
            // 
            ButtonItem_ShowVisualMap.BeginGroup = true;
            ButtonItem_ShowVisualMap.Image = (Image)resources.GetObject("ButtonItem_ShowVisualMap.Image");
            ButtonItem_ShowVisualMap.Name = "ButtonItem_ShowVisualMap";
            resources.ApplyResources(ButtonItem_ShowVisualMap, "ButtonItem_ShowVisualMap");
            // 
            // ButtonItem_ShowCollision
            // 
            ButtonItem_ShowCollision.Image = (Image)resources.GetObject("ButtonItem_ShowCollision.Image");
            ButtonItem_ShowCollision.Name = "ButtonItem_ShowCollision";
            resources.ApplyResources(ButtonItem_ShowCollision, "ButtonItem_ShowCollision");
            // 
            // ButtonItem_CopyCollisionPointer
            // 
            ButtonItem_CopyCollisionPointer.BeginGroup = true;
            ButtonItem_CopyCollisionPointer.Image = My.Resources.MyIcons.icons8_copy_16px;
            ButtonItem_CopyCollisionPointer.Name = "ButtonItem_CopyCollisionPointer";
            resources.ApplyResources(ButtonItem_CopyCollisionPointer, "ButtonItem_CopyCollisionPointer");
            // 
            // ButtonItem_RemoveObject
            // 
            ButtonItem_RemoveObject.BeginGroup = true;
            ButtonItem_RemoveObject.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            ButtonItem_RemoveObject.Name = "ButtonItem_RemoveObject";
            ButtonItem_RemoveObject.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            ButtonItem_RemoveObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            ButtonItem_RemoveObject.SymbolSize = 12.0F;
            resources.ApplyResources(ButtonItem_RemoveObject, "ButtonItem_RemoveObject");
            // 
            // CustomBankManager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContextMenuBar1);
            Controls.Add(Panel1);
            MaximizeBox = false;
            Name = "CustomBankManager";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            Panel1.ResumeLayout(false);
            LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContextMenuBar1).EndInit();
            ResumeLayout(false);
        }

        private Publics.Controls.ItemListBox ItemListBox1;

        private DevComponents.DotNetBar.ButtonX ButtonX_CreateNewObject;

        private DevComponents.DotNetBar.ButtonX ButtonX_RemoveObject;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ModelID;

        private DevComponents.DotNetBar.ButtonX ButtonX_ImportModel;

        private Panel Panel1;

        private DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1;

        private DevComponents.DotNetBar.ButtonItem CM_Object;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ShowVisualMap;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ShowCollision;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObject;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportModell;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveCollision;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportVisualMap;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportCollision;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_CopyCollisionPointer;

        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Name;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4;

        private DevComponents.DotNetBar.Layout.LayoutGroup LayoutGroup_ModelInfo;

        private DevComponents.DotNetBar.Layout.LayoutGroup LayoutGroup_CollisionPointerDestinations;

        private DevComponents.DotNetBar.ButtonX ButtonX_EditCollisionPointerDestinations;

        private DevComponents.DotNetBar.LabelX LabelX_CollisionPointerDestinationsCount;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6;
    }
}