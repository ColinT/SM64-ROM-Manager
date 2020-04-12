using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class CustomBankManager : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomBankManager));
            this._ItemListBox1 = new SM64_ROM_Manager.Publics.Controls.ItemListBox();
            this._ButtonX_CreateNewObject = new DevComponents.DotNetBar.ButtonX();
            this._ButtonX_RemoveObject = new DevComponents.DotNetBar.ButtonX();
            this._TextBoxX_ModelID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._ButtonX_ImportModel = new DevComponents.DotNetBar.ButtonX();
            this._Panel1 = new System.Windows.Forms.Panel();
            this._LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this._TextBoxX_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._LabelX_CollisionPointerDestinationsCount = new DevComponents.DotNetBar.LabelX();
            this._ButtonX_EditCollisionPointerDestinations = new DevComponents.DotNetBar.ButtonX();
            this.LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutGroup_ModelInfo = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutGroup_CollisionPointerDestinations = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this._ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.CM_Object = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ImportModell = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ImportVisualMap = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ImportCollision = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveCollision = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ShowVisualMap = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ShowCollision = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_CopyCollisionPointer = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveObject = new DevComponents.DotNetBar.ButtonItem();
            this._Panel1.SuspendLayout();
            this._LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ContextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // _ItemListBox1
            // 
            // 
            // 
            // 
            this._ItemListBox1.BackgroundStyle.Class = "ItemPanel";
            this._ItemListBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._ItemListBox1.ContainerControlProcessDialogKey = true;
            resources.ApplyResources(this._ItemListBox1, "_ItemListBox1");
            this._ItemListBox1.DragDropSupport = true;
            this._ItemListBox1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this._ItemListBox1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this._ItemListBox1.Name = "_ItemListBox1";
            this._ItemListBox1.ReserveLeftSpace = false;
            this._ItemListBox1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // _ButtonX_CreateNewObject
            // 
            this._ButtonX_CreateNewObject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this._ButtonX_CreateNewObject, "_ButtonX_CreateNewObject");
            this._ButtonX_CreateNewObject.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this._ButtonX_CreateNewObject.FocusCuesEnabled = false;
            this._ButtonX_CreateNewObject.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this._ButtonX_CreateNewObject.Name = "_ButtonX_CreateNewObject";
            this._ButtonX_CreateNewObject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX_CreateNewObject.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this._ButtonX_CreateNewObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this._ButtonX_CreateNewObject.SymbolSize = 12F;
            this._ButtonX_CreateNewObject.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // _ButtonX_RemoveObject
            // 
            this._ButtonX_RemoveObject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this._ButtonX_RemoveObject, "_ButtonX_RemoveObject");
            this._ButtonX_RemoveObject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._ButtonX_RemoveObject.FocusCuesEnabled = false;
            this._ButtonX_RemoveObject.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this._ButtonX_RemoveObject.Name = "_ButtonX_RemoveObject";
            this._ButtonX_RemoveObject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX_RemoveObject.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._ButtonX_RemoveObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this._ButtonX_RemoveObject.SymbolSize = 12F;
            this._ButtonX_RemoveObject.Click += new System.EventHandler(this.ButtonItem_RemoveObject_Click);
            // 
            // _TextBoxX_ModelID
            // 
            this._TextBoxX_ModelID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._TextBoxX_ModelID.Border.Class = "TextBoxBorder";
            this._TextBoxX_ModelID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._TextBoxX_ModelID.DisabledBackColor = System.Drawing.Color.White;
            this._TextBoxX_ModelID.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this._TextBoxX_ModelID, "_TextBoxX_ModelID");
            this._TextBoxX_ModelID.Name = "_TextBoxX_ModelID";
            this._TextBoxX_ModelID.PreventEnterBeep = true;
            this._TextBoxX_ModelID.TextChanged += new System.EventHandler(this.TextBoxX_ModelID_TextChanged);
            // 
            // _ButtonX_ImportModel
            // 
            this._ButtonX_ImportModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this._ButtonX_ImportModel, "_ButtonX_ImportModel");
            this._ButtonX_ImportModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._ButtonX_ImportModel.FocusCuesEnabled = false;
            this._ButtonX_ImportModel.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_import_16px;
            this._ButtonX_ImportModel.Name = "_ButtonX_ImportModel";
            this._ButtonX_ImportModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX_ImportModel.Click += new System.EventHandler(this.ButtonItem_ImportModell_Click);
            // 
            // _Panel1
            // 
            this._Panel1.BackColor = System.Drawing.Color.Transparent;
            this._Panel1.Controls.Add(this._ButtonX_CreateNewObject);
            this._Panel1.Controls.Add(this._ItemListBox1);
            this._Panel1.Controls.Add(this._LayoutControl1);
            resources.ApplyResources(this._Panel1, "_Panel1");
            this._Panel1.Name = "_Panel1";
            // 
            // _LayoutControl1
            // 
            this._LayoutControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._LayoutControl1.Controls.Add(this._TextBoxX_ModelID);
            this._LayoutControl1.Controls.Add(this._TextBoxX_Name);
            this._LayoutControl1.Controls.Add(this._ButtonX_ImportModel);
            this._LayoutControl1.Controls.Add(this._ButtonX_RemoveObject);
            this._LayoutControl1.Controls.Add(this._LabelX_CollisionPointerDestinationsCount);
            this._LayoutControl1.Controls.Add(this._ButtonX_EditCollisionPointerDestinations);
            resources.ApplyResources(this._LayoutControl1, "_LayoutControl1");
            this._LayoutControl1.ForeColor = System.Drawing.Color.Black;
            this._LayoutControl1.Name = "_LayoutControl1";
            // 
            // 
            // 
            this._LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem3,
            this.LayoutControlItem4,
            this.LayoutGroup_ModelInfo,
            this.LayoutGroup_CollisionPointerDestinations});
            // 
            // _TextBoxX_Name
            // 
            this._TextBoxX_Name.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._TextBoxX_Name.Border.Class = "TextBoxBorder";
            this._TextBoxX_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._TextBoxX_Name.DisabledBackColor = System.Drawing.Color.White;
            this._TextBoxX_Name.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this._TextBoxX_Name, "_TextBoxX_Name");
            this._TextBoxX_Name.Name = "_TextBoxX_Name";
            this._TextBoxX_Name.PreventEnterBeep = true;
            this._TextBoxX_Name.TextChanged += new System.EventHandler(this.TextBoxX_Name_TextChanged);
            // 
            // _LabelX_CollisionPointerDestinationsCount
            // 
            // 
            // 
            // 
            this._LabelX_CollisionPointerDestinationsCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this._LabelX_CollisionPointerDestinationsCount, "_LabelX_CollisionPointerDestinationsCount");
            this._LabelX_CollisionPointerDestinationsCount.Name = "_LabelX_CollisionPointerDestinationsCount";
            this._LabelX_CollisionPointerDestinationsCount.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // _ButtonX_EditCollisionPointerDestinations
            // 
            this._ButtonX_EditCollisionPointerDestinations.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._ButtonX_EditCollisionPointerDestinations.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._ButtonX_EditCollisionPointerDestinations.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            resources.ApplyResources(this._ButtonX_EditCollisionPointerDestinations, "_ButtonX_EditCollisionPointerDestinations");
            this._ButtonX_EditCollisionPointerDestinations.Name = "_ButtonX_EditCollisionPointerDestinations";
            this._ButtonX_EditCollisionPointerDestinations.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX_EditCollisionPointerDestinations.Click += new System.EventHandler(this.ButtonX_EditCollisionPointerDestinations_Click);
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this._ButtonX_ImportModel;
            this.LayoutControlItem3.Height = 31;
            this.LayoutControlItem3.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            this.LayoutControlItem3.Width = 99;
            this.LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this._ButtonX_RemoveObject;
            this.LayoutControlItem4.Height = 31;
            this.LayoutControlItem4.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            this.LayoutControlItem4.Width = 31;
            // 
            // LayoutGroup_ModelInfo
            // 
            this.LayoutGroup_ModelInfo.Height = 57;
            this.LayoutGroup_ModelInfo.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem2,
            this.LayoutControlItem1});
            this.LayoutGroup_ModelInfo.MinSize = new System.Drawing.Size(120, 32);
            this.LayoutGroup_ModelInfo.Name = "LayoutGroup_ModelInfo";
            this.LayoutGroup_ModelInfo.Padding = new System.Windows.Forms.Padding(0);
            this.LayoutGroup_ModelInfo.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutGroup_ModelInfo.Width = 100;
            this.LayoutGroup_ModelInfo.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this._TextBoxX_Name;
            this.LayoutControlItem2.Height = 28;
            this.LayoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            resources.ApplyResources(this.LayoutControlItem2, "LayoutControlItem2");
            this.LayoutControlItem2.Width = 100;
            this.LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this._TextBoxX_ModelID;
            this.LayoutControlItem1.Height = 28;
            this.LayoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            resources.ApplyResources(this.LayoutControlItem1, "LayoutControlItem1");
            this.LayoutControlItem1.Width = 100;
            this.LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutGroup_CollisionPointerDestinations
            // 
            this.LayoutGroup_CollisionPointerDestinations.Height = 35;
            this.LayoutGroup_CollisionPointerDestinations.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem5,
            this.LayoutControlItem6});
            this.LayoutGroup_CollisionPointerDestinations.MinSize = new System.Drawing.Size(120, 32);
            this.LayoutGroup_CollisionPointerDestinations.Name = "LayoutGroup_CollisionPointerDestinations";
            this.LayoutGroup_CollisionPointerDestinations.Padding = new System.Windows.Forms.Padding(0);
            this.LayoutGroup_CollisionPointerDestinations.TextPadding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LayoutGroup_CollisionPointerDestinations.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutGroup_CollisionPointerDestinations.Width = 100;
            this.LayoutGroup_CollisionPointerDestinations.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            this.LayoutControlItem5.Control = this._LabelX_CollisionPointerDestinationsCount;
            this.LayoutControlItem5.Height = 31;
            this.LayoutControlItem5.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem5.Name = "LayoutControlItem5";
            resources.ApplyResources(this.LayoutControlItem5, "LayoutControlItem5");
            this.LayoutControlItem5.Width = 99;
            this.LayoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem6
            // 
            this.LayoutControlItem6.Control = this._ButtonX_EditCollisionPointerDestinations;
            this.LayoutControlItem6.Height = 31;
            this.LayoutControlItem6.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem6.Name = "LayoutControlItem6";
            this.LayoutControlItem6.Width = 90;
            // 
            // _ContextMenuBar1
            // 
            this._ContextMenuBar1.AntiAlias = true;
            resources.ApplyResources(this._ContextMenuBar1, "_ContextMenuBar1");
            this._ContextMenuBar1.IsMaximized = false;
            this._ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.CM_Object});
            this._ContextMenuBar1.Name = "_ContextMenuBar1";
            this._ContextMenuBar1.Stretch = true;
            this._ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ContextMenuBar1.TabStop = false;
            // 
            // CM_Object
            // 
            this.CM_Object.AutoExpandOnClick = true;
            this.CM_Object.Name = "CM_Object";
            this.CM_Object.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_ImportModell,
            this.ButtonItem_ImportVisualMap,
            this.ButtonItem_ImportCollision,
            this.ButtonItem_RemoveCollision,
            this.ButtonItem_ShowVisualMap,
            this.ButtonItem_ShowCollision,
            this.ButtonItem_CopyCollisionPointer,
            this.ButtonItem_RemoveObject});
            resources.ApplyResources(this.CM_Object, "CM_Object");
            // 
            // ButtonItem_ImportModell
            // 
            this.ButtonItem_ImportModell.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_import_16px;
            this.ButtonItem_ImportModell.Name = "ButtonItem_ImportModell";
            resources.ApplyResources(this.ButtonItem_ImportModell, "ButtonItem_ImportModell");
            this.ButtonItem_ImportModell.Click += new System.EventHandler(this.ButtonItem_ImportModell_Click);
            // 
            // ButtonItem_ImportVisualMap
            // 
            this.ButtonItem_ImportVisualMap.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_ImportVisualMap.Image")));
            this.ButtonItem_ImportVisualMap.Name = "ButtonItem_ImportVisualMap";
            resources.ApplyResources(this.ButtonItem_ImportVisualMap, "ButtonItem_ImportVisualMap");
            this.ButtonItem_ImportVisualMap.Click += new System.EventHandler(this.ButtonItem_ImportVisualMap_Click);
            // 
            // ButtonItem_ImportCollision
            // 
            this.ButtonItem_ImportCollision.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_ImportCollision.Image")));
            this.ButtonItem_ImportCollision.Name = "ButtonItem_ImportCollision";
            resources.ApplyResources(this.ButtonItem_ImportCollision, "ButtonItem_ImportCollision");
            this.ButtonItem_ImportCollision.Click += new System.EventHandler(this.ButtonItem_ImportCollision_Click);
            // 
            // ButtonItem_RemoveCollision
            // 
            this.ButtonItem_RemoveCollision.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_2_16px;
            this.ButtonItem_RemoveCollision.Name = "ButtonItem_RemoveCollision";
            resources.ApplyResources(this.ButtonItem_RemoveCollision, "ButtonItem_RemoveCollision");
            this.ButtonItem_RemoveCollision.Click += new System.EventHandler(this.ButtonItem_RemoveCollision_Click);
            // 
            // ButtonItem_ShowVisualMap
            // 
            this.ButtonItem_ShowVisualMap.BeginGroup = true;
            this.ButtonItem_ShowVisualMap.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_ShowVisualMap.Image")));
            this.ButtonItem_ShowVisualMap.Name = "ButtonItem_ShowVisualMap";
            resources.ApplyResources(this.ButtonItem_ShowVisualMap, "ButtonItem_ShowVisualMap");
            this.ButtonItem_ShowVisualMap.Click += new System.EventHandler(this.ButtonItem_ShowVisualMap_Click);
            // 
            // ButtonItem_ShowCollision
            // 
            this.ButtonItem_ShowCollision.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_ShowCollision.Image")));
            this.ButtonItem_ShowCollision.Name = "ButtonItem_ShowCollision";
            resources.ApplyResources(this.ButtonItem_ShowCollision, "ButtonItem_ShowCollision");
            this.ButtonItem_ShowCollision.Click += new System.EventHandler(this.ButtonItem_ShowCollision_Click);
            // 
            // ButtonItem_CopyCollisionPointer
            // 
            this.ButtonItem_CopyCollisionPointer.BeginGroup = true;
            this.ButtonItem_CopyCollisionPointer.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_copy_16px;
            this.ButtonItem_CopyCollisionPointer.Name = "ButtonItem_CopyCollisionPointer";
            resources.ApplyResources(this.ButtonItem_CopyCollisionPointer, "ButtonItem_CopyCollisionPointer");
            this.ButtonItem_CopyCollisionPointer.Click += new System.EventHandler(this.ButtonItem_CopyCollisionPointer_Click);
            // 
            // ButtonItem_RemoveObject
            // 
            this.ButtonItem_RemoveObject.BeginGroup = true;
            this.ButtonItem_RemoveObject.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveObject.Name = "ButtonItem_RemoveObject";
            this.ButtonItem_RemoveObject.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonItem_RemoveObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_RemoveObject.SymbolSize = 12F;
            resources.ApplyResources(this.ButtonItem_RemoveObject, "ButtonItem_RemoveObject");
            this.ButtonItem_RemoveObject.Click += new System.EventHandler(this.ButtonItem_RemoveObject_Click);
            // 
            // CustomBankManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._ContextMenuBar1);
            this.Controls.Add(this._Panel1);
            this.MaximizeBox = false;
            this.Name = "CustomBankManager";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this._Panel1.ResumeLayout(false);
            this._LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ContextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        private Publics.Controls.ItemListBox _ItemListBox1;

        internal Publics.Controls.ItemListBox ItemListBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemListBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemListBox1 != null)
                {
                }

                _ItemListBox1 = value;
                if (_ItemListBox1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_CreateNewObject;

        internal DevComponents.DotNetBar.ButtonX ButtonX_CreateNewObject
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_CreateNewObject;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_CreateNewObject != null)
                {
                    _ButtonX_CreateNewObject.Click -= ButtonX1_Click;
                }

                _ButtonX_CreateNewObject = value;
                if (_ButtonX_CreateNewObject != null)
                {
                    _ButtonX_CreateNewObject.Click += ButtonX1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_RemoveObject;

        internal DevComponents.DotNetBar.ButtonX ButtonX_RemoveObject
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_RemoveObject;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_RemoveObject != null)
                {
                    _ButtonX_RemoveObject.Click -= ButtonItem_RemoveObject_Click;
                }

                _ButtonX_RemoveObject = value;
                if (_ButtonX_RemoveObject != null)
                {
                    _ButtonX_RemoveObject.Click += ButtonItem_RemoveObject_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ModelID;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ModelID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ModelID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ModelID != null)
                {
                    _TextBoxX_ModelID.TextChanged -= TextBoxX_ModelID_TextChanged;
                }

                _TextBoxX_ModelID = value;
                if (_TextBoxX_ModelID != null)
                {
                    _TextBoxX_ModelID.TextChanged += TextBoxX_ModelID_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_ImportModel;

        internal DevComponents.DotNetBar.ButtonX ButtonX_ImportModel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_ImportModel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_ImportModel != null)
                {
                    _ButtonX_ImportModel.Click -= ButtonItem_ImportModell_Click;
                }

                _ButtonX_ImportModel = value;
                if (_ButtonX_ImportModel != null)
                {
                    _ButtonX_ImportModel.Click += ButtonItem_ImportModell_Click;
                }
            }
        }

        private Panel _Panel1;

        internal Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel1 != null)
                {
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ContextMenuBar _ContextMenuBar1;

        internal DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ContextMenuBar1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ContextMenuBar1 != null)
                {
                }

                _ContextMenuBar1 = value;
                if (_ContextMenuBar1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _CM_Object;

        internal DevComponents.DotNetBar.ButtonItem CM_Object
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CM_Object;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CM_Object != null)
                {
                }

                _CM_Object = value;
                if (_CM_Object != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportModell;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportVisualMap;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportCollision;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveCollision;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ShowVisualMap;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ShowCollision;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_CopyCollisionPointer;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObject;
        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ShowVisualMap;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ShowVisualMap
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ShowVisualMap;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ShowVisualMap != null)
                {
                    _ButtonItem_ShowVisualMap.Click -= ButtonItem_ShowVisualMap_Click;
                }

                _ButtonItem_ShowVisualMap = value;
                if (_ButtonItem_ShowVisualMap != null)
                {
                    _ButtonItem_ShowVisualMap.Click += ButtonItem_ShowVisualMap_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ShowCollision;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ShowCollision
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ShowCollision;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ShowCollision != null)
                {
                    _ButtonItem_ShowCollision.Click -= ButtonItem_ShowCollision_Click;
                }

                _ButtonItem_ShowCollision = value;
                if (_ButtonItem_ShowCollision != null)
                {
                    _ButtonItem_ShowCollision.Click += ButtonItem_ShowCollision_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveObject;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObject
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveObject;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveObject != null)
                {
                    _ButtonItem_RemoveObject.Click -= ButtonItem_RemoveObject_Click;
                }

                _ButtonItem_RemoveObject = value;
                if (_ButtonItem_RemoveObject != null)
                {
                    _ButtonItem_RemoveObject.Click += ButtonItem_RemoveObject_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ImportModell;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ImportModell
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ImportModell;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ImportModell != null)
                {
                    _ButtonItem_ImportModell.Click -= ButtonItem_ImportModell_Click;
                }

                _ButtonItem_ImportModell = value;
                if (_ButtonItem_ImportModell != null)
                {
                    _ButtonItem_ImportModell.Click += ButtonItem_ImportModell_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveCollision;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveCollision
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveCollision;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveCollision != null)
                {
                    _ButtonItem_RemoveCollision.Click -= ButtonItem_RemoveCollision_Click;
                }

                _ButtonItem_RemoveCollision = value;
                if (_ButtonItem_RemoveCollision != null)
                {
                    _ButtonItem_RemoveCollision.Click += ButtonItem_RemoveCollision_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ImportVisualMap;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ImportVisualMap
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ImportVisualMap;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ImportVisualMap != null)
                {
                    _ButtonItem_ImportVisualMap.Click -= ButtonItem_ImportVisualMap_Click;
                }

                _ButtonItem_ImportVisualMap = value;
                if (_ButtonItem_ImportVisualMap != null)
                {
                    _ButtonItem_ImportVisualMap.Click += ButtonItem_ImportVisualMap_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ImportCollision;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ImportCollision
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ImportCollision;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ImportCollision != null)
                {
                    _ButtonItem_ImportCollision.Click -= ButtonItem_ImportCollision_Click;
                }

                _ButtonItem_ImportCollision = value;
                if (_ButtonItem_ImportCollision != null)
                {
                    _ButtonItem_ImportCollision.Click += ButtonItem_ImportCollision_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CopyCollisionPointer;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CopyCollisionPointer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CopyCollisionPointer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CopyCollisionPointer != null)
                {
                    _ButtonItem_CopyCollisionPointer.Click -= ButtonItem_CopyCollisionPointer_Click;
                }

                _ButtonItem_CopyCollisionPointer = value;
                if (_ButtonItem_CopyCollisionPointer != null)
                {
                    _ButtonItem_CopyCollisionPointer.Click += ButtonItem_CopyCollisionPointer_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControl _LayoutControl1;

        internal DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControl1 != null)
                {
                }

                _LayoutControl1 = value;
                if (_LayoutControl1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Name;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Name
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Name;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Name != null)
                {
                    _TextBoxX_Name.TextChanged -= TextBoxX_Name_TextChanged;
                }

                _TextBoxX_Name = value;
                if (_TextBoxX_Name != null)
                {
                    _TextBoxX_Name.TextChanged += TextBoxX_Name_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem2;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem2 != null)
                {
                }

                _LayoutControlItem2 = value;
                if (_LayoutControlItem2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutGroup LayoutGroup_CollisionPointerDestinations;
        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5;
        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6;
        private DevComponents.DotNetBar.ButtonItem CM_Object;
        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem1;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem1 != null)
                {
                }

                _LayoutControlItem1 = value;
                if (_LayoutControlItem1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem3;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem3 != null)
                {
                }

                _LayoutControlItem3 = value;
                if (_LayoutControlItem3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4;
        private DevComponents.DotNetBar.Layout.LayoutGroup LayoutGroup_ModelInfo;
        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem4;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem4 != null)
                {
                }

                _LayoutControlItem4 = value;
                if (_LayoutControlItem4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutGroup _LayoutGroup_ModelInfo;

        internal DevComponents.DotNetBar.Layout.LayoutGroup LayoutGroup_ModelInfo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutGroup_ModelInfo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutGroup_ModelInfo != null)
                {
                }

                _LayoutGroup_ModelInfo = value;
                if (_LayoutGroup_ModelInfo != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutGroup _LayoutGroup_CollisionPointerDestinations;

        internal DevComponents.DotNetBar.Layout.LayoutGroup LayoutGroup_CollisionPointerDestinations
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutGroup_CollisionPointerDestinations;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutGroup_CollisionPointerDestinations != null)
                {
                }

                _LayoutGroup_CollisionPointerDestinations = value;
                if (_LayoutGroup_CollisionPointerDestinations != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_EditCollisionPointerDestinations;

        internal DevComponents.DotNetBar.ButtonX ButtonX_EditCollisionPointerDestinations
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_EditCollisionPointerDestinations;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_EditCollisionPointerDestinations != null)
                {
                    _ButtonX_EditCollisionPointerDestinations.Click -= ButtonX_EditCollisionPointerDestinations_Click;
                }

                _ButtonX_EditCollisionPointerDestinations = value;
                if (_ButtonX_EditCollisionPointerDestinations != null)
                {
                    _ButtonX_EditCollisionPointerDestinations.Click += ButtonX_EditCollisionPointerDestinations_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_CollisionPointerDestinationsCount;

        internal DevComponents.DotNetBar.LabelX LabelX_CollisionPointerDestinationsCount
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_CollisionPointerDestinationsCount;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_CollisionPointerDestinationsCount != null)
                {
                }

                _LabelX_CollisionPointerDestinationsCount = value;
                if (_LabelX_CollisionPointerDestinationsCount != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem5;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem5 != null)
                {
                }

                _LayoutControlItem5 = value;
                if (_LayoutControlItem5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem6;
        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem6 != null)
                {
                }

                _LayoutControlItem6 = value;
                if (_LayoutControlItem6 != null)
                {
                }
            }
        }
    }
}