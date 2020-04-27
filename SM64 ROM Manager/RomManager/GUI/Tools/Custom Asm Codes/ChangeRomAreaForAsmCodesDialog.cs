using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SM64Lib;
using SM64Lib.ASM;
using static SM64Lib.TextValueConverter.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class ChangeRomAreaForAsmCodesDialog : OfficeForm
    {
        private readonly CustomAsmBank asmBank;

        public ChangeRomAreaForAsmCodesDialog(CustomAsmBank asmBank)
        {
            this.asmBank = asmBank;

            InitializeComponent();
            UpdateAmbientColors();

            textBoxX_RomAddress.Text = TextFromValue(asmBank.Config.RomStartAddress);
            textBoxX_RamAddress.Text = TextFromValue(asmBank.Config.RamStartAddress);
            textBoxX_Length.Text = TextFromValue(asmBank.Config.MaxLength);
        }

        private void ButtonX_Save_Click(object sender, EventArgs e)
        {
            asmBank.Config.RomStartAddress = ValueFromText(textBoxX_RomAddress.Text);
            asmBank.Config.RamStartAddress = ValueFromText(textBoxX_RamAddress.Text);
            asmBank.Config.MaxLength = ValueFromText(textBoxX_Length.Text);

            DialogResult = DialogResult.OK;
        }
    }
}