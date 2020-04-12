using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SM64Lib;
using SM64Lib.Configuration;
using SM64Lib.Objects.ModelBanks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SM64Lib.TextValueConverter.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class CustomModelSelector : OfficeForm
    {
        private readonly RomManager romManager;
        public CustomModelConfig Model { get; set; } = null;

        public CustomModelSelector(RomManager romManager)
        {
            this.romManager = romManager;
            InitializeComponent();
        }

        private void LoadList()
        {
            Node nToSelect = null;

            AdvTree1.BeginUpdate();
            AdvTree1.Nodes.Clear();

            // Global Object Bank
            goThourghtBank(romManager.GlobalModelBank, "Global Object Bank", AdvTree1.Nodes);

            // Local Object Banks
            var nlob = new Node("Local Object Bank");
            foreach (var lvl in romManager.Levels)
            {
                string levelName = romManager.RomConfig.GetLevelConfig(lvl.LevelID)?.LevelName;
                if (string.IsNullOrEmpty(levelName))
                    levelName = romManager.LevelInfoData.FirstOrDefault(n => n.ID == lvl.LevelID).Name;
                goThourghtBank(lvl.LocalObjectBank, levelName, nlob.Nodes);
            }
            AdvTree1.Nodes.Add(nlob);

            void goThourghtBank(CustomModelBank bank, string bankName, NodeCollection collection)
            {
                var n = new Node(bankName);

                foreach (var mdl in bank.Models)
                {
                    var nMdl = GetNode(mdl);
                    n.Nodes.Add(nMdl);
                    if (nMdl is object)
                        nToSelect = nMdl;
                }

                collection.Add(n);
            }

            AdvTree1.EndUpdate();

            if (nToSelect is object)
            {
                AdvTree1.SelectedNode = nToSelect;
                nToSelect.EnsureVisible();
            }
        }

        private Node GetNode(CustomModel model)
        {
            var n = new Node()
            {
                Text = model.Config.Name,
                Tag = model.Config
            };
            n.Cells.Add(new Cell(TextFromValue(model.ModelID)));
            return n;
        }

        private void AdvTree1_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            Model = e.Node?.Tag as CustomModelConfig;
            buttonX_Select.Enabled = Model != null;
        }

        private void CustomModelSelector_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
