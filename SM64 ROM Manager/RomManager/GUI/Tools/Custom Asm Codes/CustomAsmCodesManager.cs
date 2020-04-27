using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SM64Lib;

namespace SM64_ROM_Manager
{
    public partial class CustomAsmCodesManager : DevComponents.DotNetBar.OfficeForm
    {
        private readonly RomManager rommgr;

        public CustomAsmCodesManager(RomManager rommgr)
        {
            this.rommgr = rommgr;

            InitializeComponent();
            UpdateAmbientColors();
        }

        private void ButtonItem_AsmToHexConverter_Click(object sender, EventArgs e)
        {
            var frm = new AsmToHexConverter();
            frm.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            var frm = new ChangeRomAreaForAsmCodesDialog(rommgr);
            frm.ShowDialog(this);
        }
    }
}