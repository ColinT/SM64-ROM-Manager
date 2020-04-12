using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddressListEditor : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressListEditor));
            this._ItemPanel_Values = new DevComponents.DotNetBar.ItemPanel();
            this._LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this._TextBoxX_Value = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._ButtonX_Hinzufügen = new DevComponents.DotNetBar.ButtonX();
            this._ButtonX_Entfernen = new DevComponents.DotNetBar.ButtonX();
            this.LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this._LayoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ItemPanel_Values
            // 
            resources.ApplyResources(this._ItemPanel_Values, "_ItemPanel_Values");
            this._ItemPanel_Values.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this._ItemPanel_Values.BackgroundStyle.Class = "ItemPanel";
            this._ItemPanel_Values.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._ItemPanel_Values.ContainerControlProcessDialogKey = true;
            this._ItemPanel_Values.DragDropSupport = true;
            this._ItemPanel_Values.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this._ItemPanel_Values.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this._ItemPanel_Values.Name = "_ItemPanel_Values";
            this._ItemPanel_Values.ReserveLeftSpace = false;
            this._ItemPanel_Values.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ItemPanel_Values.SelectedIndexChanged += new System.EventHandler(this.ItemPanel_Values_SelectedIndexChanged);
            // 
            // _LayoutControl1
            // 
            this._LayoutControl1.BackColor = System.Drawing.Color.Transparent;
            this._LayoutControl1.Controls.Add(this._TextBoxX_Value);
            this._LayoutControl1.Controls.Add(this._ButtonX_Hinzufügen);
            this._LayoutControl1.Controls.Add(this._ButtonX_Entfernen);
            resources.ApplyResources(this._LayoutControl1, "_LayoutControl1");
            this._LayoutControl1.ForeColor = System.Drawing.Color.Black;
            this._LayoutControl1.Name = "_LayoutControl1";
            // 
            // 
            // 
            this._LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem1,
            this.LayoutControlItem2,
            this.LayoutControlItem3});
            // 
            // _TextBoxX_Value
            // 
            this._TextBoxX_Value.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._TextBoxX_Value.Border.Class = "TextBoxBorder";
            this._TextBoxX_Value.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._TextBoxX_Value.DisabledBackColor = System.Drawing.Color.White;
            this._TextBoxX_Value.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this._TextBoxX_Value, "_TextBoxX_Value");
            this._TextBoxX_Value.Name = "_TextBoxX_Value";
            this._TextBoxX_Value.PreventEnterBeep = true;
            this._TextBoxX_Value.TextChanged += new System.EventHandler(this.TextBoxX_Value_TextChanged);
            // 
            // _ButtonX_Hinzufügen
            // 
            this._ButtonX_Hinzufügen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._ButtonX_Hinzufügen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._ButtonX_Hinzufügen.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(this._ButtonX_Hinzufügen, "_ButtonX_Hinzufügen");
            this._ButtonX_Hinzufügen.Name = "_ButtonX_Hinzufügen";
            this._ButtonX_Hinzufügen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX_Hinzufügen.Click += new System.EventHandler(this.ButtonX_Hinzufügen_Click);
            // 
            // _ButtonX_Entfernen
            // 
            this._ButtonX_Entfernen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._ButtonX_Entfernen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._ButtonX_Entfernen.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            resources.ApplyResources(this._ButtonX_Entfernen, "_ButtonX_Entfernen");
            this._ButtonX_Entfernen.Name = "_ButtonX_Entfernen";
            this._ButtonX_Entfernen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX_Entfernen.Click += new System.EventHandler(this.ButtonX_Entfernen_Click);
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this._TextBoxX_Value;
            this.LayoutControlItem1.Height = 28;
            this.LayoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            this.LayoutControlItem1.Width = 100;
            this.LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this._ButtonX_Hinzufügen;
            this.LayoutControlItem2.Height = 31;
            this.LayoutControlItem2.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            this.LayoutControlItem2.Width = 50;
            this.LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this._ButtonX_Entfernen;
            this.LayoutControlItem3.Height = 31;
            this.LayoutControlItem3.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            this.LayoutControlItem3.Width = 50;
            this.LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // AddressListEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._ItemPanel_Values);
            this.Controls.Add(this._LayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddressListEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this._LayoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.ItemPanel _ItemPanel_Values;

        internal DevComponents.DotNetBar.ItemPanel ItemPanel_Values
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemPanel_Values;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemPanel_Values != null)
                {
                    _ItemPanel_Values.SelectedIndexChanged -= ItemPanel_Values_SelectedIndexChanged;
                }

                _ItemPanel_Values = value;
                if (_ItemPanel_Values != null)
                {
                    _ItemPanel_Values.SelectedIndexChanged += ItemPanel_Values_SelectedIndexChanged;
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Value;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Value
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Value;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Value != null)
                {
                    _TextBoxX_Value.TextChanged -= TextBoxX_Value_TextChanged;
                }

                _TextBoxX_Value = value;
                if (_TextBoxX_Value != null)
                {
                    _TextBoxX_Value.TextChanged += TextBoxX_Value_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Hinzufügen;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Hinzufügen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Hinzufügen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Hinzufügen != null)
                {
                    _ButtonX_Hinzufügen.Click -= ButtonX_Hinzufügen_Click;
                }

                _ButtonX_Hinzufügen = value;
                if (_ButtonX_Hinzufügen != null)
                {
                    _ButtonX_Hinzufügen.Click += ButtonX_Hinzufügen_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Entfernen;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Entfernen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Entfernen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Entfernen != null)
                {
                    _ButtonX_Entfernen.Click -= ButtonX_Entfernen_Click;
                }

                _ButtonX_Entfernen = value;
                if (_ButtonX_Entfernen != null)
                {
                    _ButtonX_Entfernen.Click += ButtonX_Entfernen_Click;
                }
            }
        }

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

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;
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

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;

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
    }
}