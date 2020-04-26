using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace SM64_ROM_Manager
{
    public partial class CustomAsmCodesManager : DevComponents.DotNetBar.OfficeForm
    {
        public CustomAsmCodesManager()
        {
            InitializeComponent();
        }

        private void ButtonItem_AsmToHexConverter_Click(object sender, EventArgs e)
        {
            var frm = new AsmToHexConverter();
            frm.Show();
        }
    }
}