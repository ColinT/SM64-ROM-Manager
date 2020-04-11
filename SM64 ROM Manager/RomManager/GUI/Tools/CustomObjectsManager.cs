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
    public partial class CustomObjectsManager : OfficeForm
    {
        private RomManager rommgr;

        public CustomObjectsManager(RomManager rommgr)
        {
            this.rommgr = rommgr;
            InitializeComponent();
        }
    }
}