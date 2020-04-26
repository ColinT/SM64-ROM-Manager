using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    public partial class AsmToHexConverter : OfficeForm
    {
        public AsmToHexConverter()
        {
            InitializeComponent();
        }

        private void ButtonX_CopyHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxX_Hex.Text);
        }

        private void ButtonX_Convert_Click(object sender, EventArgs e)
        {
            byte[] bytes;
            var sb = new StringBuilder();

            ProgBar.Visible = true;
            ButtonX_Convert.Enabled = false;

            try
            {
                 bytes = PatchScripts.PatchingManager.ConvertAsmToBytes(textBoxX_Hex.Text);
            }
            catch (Exception)
            {
                bytes = null;
            }

            if (bytes is object)
            {
                foreach (var b in bytes)
                {
                    if (sb.Length != 0)
                        sb.Append(" ");
                    sb.Append(b.ToString("X2"));
                }
            }

            textBoxX_Hex.Text = sb.ToString();

            ProgBar.Visible = false;
            ButtonX_Convert.Enabled = true;
        }
    }
}
