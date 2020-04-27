using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SM64Lib;
using static SM64Lib.TextValueConverter.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class ChangeRomAreaForAsmCodesDialog : DevComponents.DotNetBar.OfficeForm
    {
        private readonly RomManager rommgr;

        public ChangeRomAreaForAsmCodesDialog(RomManager rommgr)
        {
            this.rommgr = rommgr;

            InitializeComponent();
            UpdateAmbientColors();

            textBoxX_RomAddress.Text = TextFromValue(rommgr.GlobalCustomAsmBank.Config.RomStartAddress);
            textBoxX_RamAddress.Text = TextFromValue(rommgr.GlobalCustomAsmBank.Config.RamStartAddress);
            textBoxX_Length.Text = TextFromValue(rommgr.GlobalCustomAsmBank.Config.MaxLength);
        }

        private void ButtonX_Save_Click(object sender, EventArgs e)
        {
            rommgr.GlobalCustomAsmBank.Config.RomStartAddress = ValueFromText(textBoxX_RomAddress.Text);
            rommgr.GlobalCustomAsmBank.Config.RamStartAddress = ValueFromText(textBoxX_RamAddress.Text);
            rommgr.GlobalCustomAsmBank.Config.MaxLength = ValueFromText(textBoxX_Length.Text);

            DialogResult = DialogResult.OK;
        }
    }
}