using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ProgressUpdater
{
    [DesignerGenerated()]
    public partial class Form1 : DevComponents.DotNetBar.OfficeForm
    {

        // Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

        // Wird vom Windows Form-Designer benötigt.
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Panel1 = new Panel();
            ButtonX_PasteClipboard = new DevComponents.DotNetBar.ButtonX();
            ButtonX_PasteClipboard.Click += new EventHandler(ButtonX1_Click);
            PictureBox1 = new PictureBox();
            Panel2 = new Panel();
            ButtonX_Upload = new DevComponents.DotNetBar.ButtonX();
            ButtonX_Upload.Click += new EventHandler(ButtonX_Upload_Click);
            LabelX5 = new DevComponents.DotNetBar.LabelX();
            LabelX2 = new DevComponents.DotNetBar.LabelX();
            TextBoxX_WebDavUploadPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            TextBoxX_ProxPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            LabelX3 = new DevComponents.DotNetBar.LabelX();
            TextBoxX_WebDavUploadUri = new DevComponents.DotNetBar.Controls.TextBoxX();
            LabelX4 = new DevComponents.DotNetBar.LabelX();
            TextBoxX_WebDavUploadUsr = new DevComponents.DotNetBar.Controls.TextBoxX();
            LabelX6 = new DevComponents.DotNetBar.LabelX();
            TextBoxX_Version = new DevComponents.DotNetBar.Controls.TextBoxX();
            LabelX1 = new DevComponents.DotNetBar.LabelX();
            TextBoxX_ProxUsr = new DevComponents.DotNetBar.Controls.TextBoxX();
            StyleManager1 = new DevComponents.DotNetBar.StyleManager(components);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Transparent;
            Panel1.Controls.Add(ButtonX_PasteClipboard);
            Panel1.Controls.Add(PictureBox1);
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(694, 508);
            Panel1.TabIndex = 0;
            // 
            // ButtonX_PasteClipboard
            // 
            ButtonX_PasteClipboard.AccessibleRole = AccessibleRole.PushButton;
            ButtonX_PasteClipboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonX_PasteClipboard.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ButtonX_PasteClipboard.Location = new Point(562, 3);
            ButtonX_PasteClipboard.Name = "ButtonX_PasteClipboard";
            ButtonX_PasteClipboard.Size = new Size(129, 23);
            ButtonX_PasteClipboard.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ButtonX_PasteClipboard.TabIndex = 0;
            ButtonX_PasteClipboard.Text = "Paste from Clipboard";
            // 
            // PictureBox1
            // 
            PictureBox1.Dock = DockStyle.Fill;
            PictureBox1.Location = new Point(200, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(494, 508);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(ButtonX_Upload);
            Panel2.Controls.Add(LabelX5);
            Panel2.Controls.Add(LabelX2);
            Panel2.Controls.Add(TextBoxX_WebDavUploadPwd);
            Panel2.Controls.Add(TextBoxX_ProxPwd);
            Panel2.Controls.Add(LabelX3);
            Panel2.Controls.Add(TextBoxX_WebDavUploadUri);
            Panel2.Controls.Add(LabelX4);
            Panel2.Controls.Add(TextBoxX_WebDavUploadUsr);
            Panel2.Controls.Add(LabelX6);
            Panel2.Controls.Add(TextBoxX_Version);
            Panel2.Controls.Add(LabelX1);
            Panel2.Controls.Add(TextBoxX_ProxUsr);
            Panel2.Dock = DockStyle.Left;
            Panel2.Location = new Point(0, 0);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(200, 508);
            Panel2.TabIndex = 1;
            // 
            // ButtonX_Upload
            // 
            ButtonX_Upload.AccessibleRole = AccessibleRole.PushButton;
            ButtonX_Upload.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonX_Upload.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            ButtonX_Upload.Location = new Point(3, 465);
            ButtonX_Upload.Name = "ButtonX_Upload";
            ButtonX_Upload.Size = new Size(194, 40);
            ButtonX_Upload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ButtonX_Upload.TabIndex = 10;
            ButtonX_Upload.Text = "Upload";
            // 
            // LabelX5
            // 
            LabelX5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX5.Location = new Point(3, 113);
            LabelX5.Name = "LabelX5";
            LabelX5.Size = new Size(194, 23);
            LabelX5.TabIndex = 1;
            LabelX5.Text = "WebDav Password:";
            // 
            // LabelX2
            // 
            LabelX2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX2.Location = new Point(3, 223);
            LabelX2.Name = "LabelX2";
            LabelX2.Size = new Size(194, 23);
            LabelX2.TabIndex = 1;
            LabelX2.Text = "Proxy Password:";
            // 
            // TextBoxX_WebDavUploadPwd
            // 
            TextBoxX_WebDavUploadPwd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxX_WebDavUploadPwd.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_WebDavUploadPwd.Border.Class = "TextBoxBorder";
            TextBoxX_WebDavUploadPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_WebDavUploadPwd.DisabledBackColor = Color.White;
            TextBoxX_WebDavUploadPwd.ForeColor = Color.Black;
            TextBoxX_WebDavUploadPwd.Location = new Point(3, 142);
            TextBoxX_WebDavUploadPwd.Name = "TextBoxX_WebDavUploadPwd";
            TextBoxX_WebDavUploadPwd.PreventEnterBeep = true;
            TextBoxX_WebDavUploadPwd.Size = new Size(194, 20);
            TextBoxX_WebDavUploadPwd.TabIndex = 3;
            TextBoxX_WebDavUploadPwd.UseSystemPasswordChar = true;
            // 
            // TextBoxX_ProxPwd
            // 
            TextBoxX_ProxPwd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxX_ProxPwd.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_ProxPwd.Border.Class = "TextBoxBorder";
            TextBoxX_ProxPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_ProxPwd.DisabledBackColor = Color.White;
            TextBoxX_ProxPwd.ForeColor = Color.Black;
            TextBoxX_ProxPwd.Location = new Point(3, 252);
            TextBoxX_ProxPwd.Name = "TextBoxX_ProxPwd";
            TextBoxX_ProxPwd.PreventEnterBeep = true;
            TextBoxX_ProxPwd.Size = new Size(194, 20);
            TextBoxX_ProxPwd.TabIndex = 5;
            TextBoxX_ProxPwd.UseSystemPasswordChar = true;
            // 
            // LabelX3
            // 
            LabelX3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX3.Location = new Point(3, 3);
            LabelX3.Name = "LabelX3";
            LabelX3.Size = new Size(194, 23);
            LabelX3.TabIndex = 1;
            LabelX3.Text = "WebDav Directory Address:";
            // 
            // TextBoxX_WebDavUploadUri
            // 
            TextBoxX_WebDavUploadUri.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxX_WebDavUploadUri.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_WebDavUploadUri.Border.Class = "TextBoxBorder";
            TextBoxX_WebDavUploadUri.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_WebDavUploadUri.DisabledBackColor = Color.White;
            TextBoxX_WebDavUploadUri.ForeColor = Color.Black;
            TextBoxX_WebDavUploadUri.Location = new Point(3, 32);
            TextBoxX_WebDavUploadUri.Name = "TextBoxX_WebDavUploadUri";
            TextBoxX_WebDavUploadUri.PreventEnterBeep = true;
            TextBoxX_WebDavUploadUri.Size = new Size(194, 20);
            TextBoxX_WebDavUploadUri.TabIndex = 1;
            // 
            // LabelX4
            // 
            LabelX4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX4.Location = new Point(3, 58);
            LabelX4.Name = "LabelX4";
            LabelX4.Size = new Size(194, 23);
            LabelX4.TabIndex = 1;
            LabelX4.Text = "WebDav Username:";
            // 
            // TextBoxX_WebDavUploadUsr
            // 
            TextBoxX_WebDavUploadUsr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxX_WebDavUploadUsr.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_WebDavUploadUsr.Border.Class = "TextBoxBorder";
            TextBoxX_WebDavUploadUsr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_WebDavUploadUsr.DisabledBackColor = Color.White;
            TextBoxX_WebDavUploadUsr.ForeColor = Color.Black;
            TextBoxX_WebDavUploadUsr.Location = new Point(3, 87);
            TextBoxX_WebDavUploadUsr.Name = "TextBoxX_WebDavUploadUsr";
            TextBoxX_WebDavUploadUsr.PreventEnterBeep = true;
            TextBoxX_WebDavUploadUsr.Size = new Size(194, 20);
            TextBoxX_WebDavUploadUsr.TabIndex = 2;
            // 
            // LabelX6
            // 
            LabelX6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX6.Location = new Point(3, 278);
            LabelX6.Name = "LabelX6";
            LabelX6.Size = new Size(194, 23);
            LabelX6.TabIndex = 1;
            LabelX6.Text = "Version:";
            // 
            // TextBoxX_Version
            // 
            TextBoxX_Version.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxX_Version.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_Version.Border.Class = "TextBoxBorder";
            TextBoxX_Version.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_Version.DisabledBackColor = Color.White;
            TextBoxX_Version.ForeColor = Color.Black;
            TextBoxX_Version.Location = new Point(3, 307);
            TextBoxX_Version.Name = "TextBoxX_Version";
            TextBoxX_Version.PreventEnterBeep = true;
            TextBoxX_Version.Size = new Size(194, 20);
            TextBoxX_Version.TabIndex = 6;
            TextBoxX_Version.WatermarkText = "e.g. 1.2.0.0";
            // 
            // LabelX1
            // 
            LabelX1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            LabelX1.Location = new Point(3, 168);
            LabelX1.Name = "LabelX1";
            LabelX1.Size = new Size(194, 23);
            LabelX1.TabIndex = 1;
            LabelX1.Text = "Proxy Username:";
            // 
            // TextBoxX_ProxUsr
            // 
            TextBoxX_ProxUsr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxX_ProxUsr.BackColor = Color.White;
            // 
            // 
            // 
            TextBoxX_ProxUsr.Border.Class = "TextBoxBorder";
            TextBoxX_ProxUsr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            TextBoxX_ProxUsr.DisabledBackColor = Color.White;
            TextBoxX_ProxUsr.ForeColor = Color.Black;
            TextBoxX_ProxUsr.Location = new Point(3, 197);
            TextBoxX_ProxUsr.Name = "TextBoxX_ProxUsr";
            TextBoxX_ProxUsr.PreventEnterBeep = true;
            TextBoxX_ProxUsr.Size = new Size(194, 20);
            TextBoxX_ProxUsr.TabIndex = 4;
            // 
            // StyleManager1
            // 
            StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255))), Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(57)), Conversions.ToInteger(Conversions.ToByte(123))));
            // 
            // Form1
            // 
            AcceptButton = ButtonX_Upload;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 508);
            Controls.Add(Panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SM64RM Progress Updater";
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel Panel1;


        private DevComponents.DotNetBar.StyleManager StyleManager1;


        private PictureBox PictureBox1;


        private Panel Panel2;


        private DevComponents.DotNetBar.ButtonX ButtonX_Upload;


        private DevComponents.DotNetBar.LabelX LabelX1;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ProxUsr;


        private DevComponents.DotNetBar.LabelX LabelX2;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ProxPwd;


        private DevComponents.DotNetBar.LabelX LabelX5;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_WebDavUploadPwd;


        private DevComponents.DotNetBar.LabelX LabelX3;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_WebDavUploadUri;


        private DevComponents.DotNetBar.LabelX LabelX4;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_WebDavUploadUsr;


        private DevComponents.DotNetBar.ButtonX ButtonX_PasteClipboard;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Version;


        private DevComponents.DotNetBar.LabelX LabelX6;

    }
}