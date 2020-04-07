namespace SM64_ROM_Manager
{
    partial class BehaviorBankManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BehaviorBankManager));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_AddBehav = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveBehav = new DevComponents.DotNetBar.ButtonItem();
            this.AdvTree_Behaviors = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.TabControl_Behav = new DevComponents.DotNetBar.TabControl();
            this.TabItem_BehavProps = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.TabItem_BehavScript = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.richTextBoxEx1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.TextBoxX_BehavName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.textBoxX_BehavColPtr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkBoxX_BehavEnableColPtr = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree_Behaviors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl_Behav)).BeginInit();
            this.TabControl_Behav.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.layoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_AddBehav,
            this.ButtonItem_RemoveBehav});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(684, 24);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            // 
            // ButtonItem_AddBehav
            // 
            this.ButtonItem_AddBehav.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_AddBehav.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem_AddBehav.Name = "ButtonItem_AddBehav";
            this.ButtonItem_AddBehav.Text = "Add Behavior";
            // 
            // ButtonItem_RemoveBehav
            // 
            this.ButtonItem_RemoveBehav.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_RemoveBehav.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveBehav.Name = "ButtonItem_RemoveBehav";
            this.ButtonItem_RemoveBehav.Text = "Remove Behavior";
            // 
            // AdvTree_Behaviors
            // 
            this.AdvTree_Behaviors.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTree_Behaviors.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree_Behaviors.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree_Behaviors.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree_Behaviors.Columns.Add(this.columnHeader1);
            this.AdvTree_Behaviors.Columns.Add(this.columnHeader2);
            this.AdvTree_Behaviors.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdvTree_Behaviors.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.AdvTree_Behaviors.Location = new System.Drawing.Point(0, 24);
            this.AdvTree_Behaviors.Name = "AdvTree_Behaviors";
            this.AdvTree_Behaviors.NodesConnector = this.nodeConnector1;
            this.AdvTree_Behaviors.NodeStyle = this.elementStyle1;
            this.AdvTree_Behaviors.PathSeparator = ";";
            this.AdvTree_Behaviors.Size = new System.Drawing.Size(300, 387);
            this.AdvTree_Behaviors.Styles.Add(this.elementStyle1);
            this.AdvTree_Behaviors.TabIndex = 2;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // TabControl_Behav
            // 
            this.TabControl_Behav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabControl_Behav.CanReorderTabs = true;
            this.TabControl_Behav.Controls.Add(this.tabControlPanel1);
            this.TabControl_Behav.Controls.Add(this.tabControlPanel2);
            this.TabControl_Behav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Behav.ForeColor = System.Drawing.Color.Black;
            this.TabControl_Behav.Location = new System.Drawing.Point(300, 24);
            this.TabControl_Behav.Name = "TabControl_Behav";
            this.TabControl_Behav.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabControl_Behav.SelectedTabIndex = 0;
            this.TabControl_Behav.Size = new System.Drawing.Size(384, 387);
            this.TabControl_Behav.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.TabControl_Behav.TabIndex = 3;
            this.TabControl_Behav.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.TabControl_Behav.Tabs.Add(this.TabItem_BehavProps);
            this.TabControl_Behav.Tabs.Add(this.TabItem_BehavScript);
            // 
            // TabItem_BehavProps
            // 
            this.TabItem_BehavProps.AttachedControl = this.tabControlPanel1;
            this.TabItem_BehavProps.Name = "TabItem_BehavProps";
            this.TabItem_BehavProps.Text = "Properties";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.layoutControl1);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 27);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(384, 360);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.TabItem_BehavProps;
            // 
            // TabItem_BehavScript
            // 
            this.TabItem_BehavScript.AttachedControl = this.tabControlPanel2;
            this.TabItem_BehavScript.Name = "TabItem_BehavScript";
            this.TabItem_BehavScript.Text = "Script";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.richTextBoxEx1);
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 27);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(384, 360);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 5;
            this.tabControlPanel2.TabItem = this.TabItem_BehavScript;
            // 
            // richTextBoxEx1
            // 
            // 
            // 
            // 
            this.richTextBoxEx1.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx1.Location = new System.Drawing.Point(1, 1);
            this.richTextBoxEx1.Name = "richTextBoxEx1";
            this.richTextBoxEx1.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1031{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx1.Size = new System.Drawing.Size(382, 358);
            this.richTextBoxEx1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.TextBoxX_BehavName);
            this.layoutControl1.Controls.Add(this.textBoxX_BehavColPtr);
            this.layoutControl1.Controls.Add(this.checkBoxX_BehavEnableColPtr);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.ForeColor = System.Drawing.Color.Black;
            this.layoutControl1.Location = new System.Drawing.Point(1, 1);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControl1.Size = new System.Drawing.Size(382, 358);
            this.layoutControl1.TabIndex = 0;
            // 
            // TextBoxX_BehavName
            // 
            this.TextBoxX_BehavName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_BehavName.Border.Class = "TextBoxBorder";
            this.TextBoxX_BehavName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_BehavName.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_BehavName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_BehavName.Location = new System.Drawing.Point(96, 4);
            this.TextBoxX_BehavName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.TextBoxX_BehavName.Name = "TextBoxX_BehavName";
            this.TextBoxX_BehavName.PreventEnterBeep = true;
            this.TextBoxX_BehavName.Size = new System.Drawing.Size(282, 20);
            this.TextBoxX_BehavName.TabIndex = 0;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TextBoxX_BehavName;
            this.layoutControlItem1.Height = 28;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "Name:";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // textBoxX_BehavColPtr
            // 
            this.textBoxX_BehavColPtr.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_BehavColPtr.Border.Class = "TextBoxBorder";
            this.textBoxX_BehavColPtr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_BehavColPtr.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX_BehavColPtr.ForeColor = System.Drawing.Color.Black;
            this.textBoxX_BehavColPtr.Location = new System.Drawing.Point(96, 32);
            this.textBoxX_BehavColPtr.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.textBoxX_BehavColPtr.Name = "textBoxX_BehavColPtr";
            this.textBoxX_BehavColPtr.PreventEnterBeep = true;
            this.textBoxX_BehavColPtr.Size = new System.Drawing.Size(182, 20);
            this.textBoxX_BehavColPtr.TabIndex = 1;
            // 
            // checkBoxX_BehavEnableColPtr
            // 
            // 
            // 
            // 
            this.checkBoxX_BehavEnableColPtr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_BehavEnableColPtr.Location = new System.Drawing.Point(286, 32);
            this.checkBoxX_BehavEnableColPtr.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.checkBoxX_BehavEnableColPtr.Name = "checkBoxX_BehavEnableColPtr";
            this.checkBoxX_BehavEnableColPtr.Size = new System.Drawing.Size(92, 20);
            this.checkBoxX_BehavEnableColPtr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_BehavEnableColPtr.TabIndex = 2;
            this.checkBoxX_BehavEnableColPtr.Text = "Enable";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textBoxX_BehavColPtr;
            this.layoutControlItem2.Height = 28;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "Collision Pointer:";
            this.layoutControlItem2.Width = 99;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkBoxX_BehavEnableColPtr;
            this.layoutControlItem3.Height = 28;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width.Relative = 60;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width.Absolute = 80;
            // 
            // BehaviorBankManager
            // 
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.TabControl_Behav);
            this.Controls.Add(this.AdvTree_Behaviors);
            this.Controls.Add(this.bar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BehaviorBankManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Behavior Bank Manager";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree_Behaviors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl_Behav)).EndInit();
            this.TabControl_Behav.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.layoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_AddBehav;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveBehav;
        private DevComponents.AdvTree.AdvTree AdvTree_Behaviors;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.TabControl TabControl_Behav;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem TabItem_BehavProps;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem TabItem_BehavScript;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx1;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_BehavName;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_BehavColPtr;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_BehavEnableColPtr;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
    }
}