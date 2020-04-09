using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Validator;
using SM64Lib;
using SM64Lib.Behaviors;
using static SM64Lib.TextValueConverter.TextValueConverter;
using Timer = System.Timers.Timer;

namespace SM64_ROM_Manager
{
    public partial class BehaviorBankManager : OfficeForm
    {
        // D e f a u l t   N o d e s

        private Node nBehavVanilla = new Node("Vanilla") { Expanded = true };
        private Node nBehavCustom = new Node("Custom") { Expanded = true };

        // F i e l d s

        private RomManager rommgr;
        private Behavior curBehav = null;
        private bool loadingBehavior = false;
        private Timer Timer_PropsChanged;

        // C o n s t r u c t o r

        public BehaviorBankManager(RomManager rommgr)
        {
            this.rommgr = rommgr;

            General.LoadBehaviorInfosIfEmpty();

            InitializeComponent();
            UpdateAmbientColors();
            StyleManager.UpdateAmbientColors(RichTextBoxEx_Script);

            AdvTree_Behaviors.Nodes.AddRange(new[] { nBehavVanilla, nBehavCustom });

            Timer_PropsChanged = new Timer(1000) { SynchronizingObject = this, AutoReset = false };
            Timer_PropsChanged.Elapsed += Timer_PropsChanged_Elapsed;
        }

        // P r o p e r t i e s

        private bool IsEditScript
        {
            get => TabControl_Behav.SelectedTab == TabItem_BehavScript;
        }

        private bool IsEditProps
        {
            get => TabControl_Behav.SelectedTab == TabItem_BehavProps;
        }

        // T i m e r   E v e n t s

        private void Timer_PropsChanged_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (curBehav is object)
                UpdateNode(curBehav);
        }

        // F e a t u r e s

        private void LoadBehaviors(bool vanilla)
        {
            NodeCollection nodes = GetNodeCollection(vanilla);

            if (nodes is object)
            {
                AdvTree_Behaviors.BeginUpdate();
                nodes.Clear();

                foreach (var behav in rommgr.GlobalBehaviorBank.Behaviors)
                {
                    if (behav.Config.IsVanilla == vanilla)
                        nodes.Add(GetNode(behav));
                }

                AdvTree_Behaviors.EndUpdate();
            }
        }

        private NodeCollection GetNodeCollection(bool vanilla)
        {
            NodeCollection nodes = null;

            switch (vanilla)
            {
                case true:
                    nodes = nBehavVanilla.Nodes;
                    break;
                case false:
                    nodes = nBehavCustom.Nodes;
                    break;
            }

            return nodes;
        }

        private Node GetNode(Behavior behav)
        {
            var n = new Node()
            {
                Tag = behav
            };

            n.Cells.Add(new Cell() { Name = "segaddr" });
            UpdateNode(n);

            return n;
        }

        private void UpdateNode(Behavior behav)
        {
            Node n = null;
            NodeCollection nodes = GetNodeCollection(behav.Config.IsVanilla);

            if (nodes is object)
            {
                foreach (Node node in nodes)
                {
                    if (n == null && node.Tag == behav)
                        n = node;
                }
            }

            UpdateNode(n);
        }

        private void UpdateNode(Node n)
        {
            if (n is object && n.Tag is Behavior)
            {
                var behav = (Behavior)n.Tag;
                string txt;

                if (!string.IsNullOrEmpty(behav.Config.Name))
                    txt = behav.Config.Name;
                else
                {
                    var info = General.BehaviorInfos.GetByBehaviorAddress((uint)behav.Config.BankAddress);
                    var infoCustom = General.BehaviorInfosCustom.GetByBehaviorAddress((uint)behav.Config.BankAddress);

                    if (infoCustom is object)
                        txt = infoCustom.Name;
                    else if (info is object)
                        txt = info.Name;
                    else
                        txt = "Unnamed";
                }

                n.Text = txt;
                n.Cells["segaddr"].Text = TextFromValue(behav.Config.BankAddress);
            }
        }

        private void LoadBehavior()
        {
            var isBehav = curBehav is object;
            TabControl_Behav.Enabled = isBehav;

            if (isBehav)
            {
                loadingBehavior = true;

                if (IsEditProps)
                {
                    TextBoxX_BehavName.Text = curBehav.Config.Name;
                    checkBoxX_BehavEnableColPtr.Checked = curBehav.EnableCollisionPointer;
                    textBoxX_BehavColPtr.Text = TextFromValue(curBehav.CollisionPointer);
                    checkBoxX_BehavEnableColPtr.Enabled = !curBehav.Config.IsVanilla;
                    textBoxX_BehavColPtr.ReadOnly = curBehav.Config.IsVanilla;
                }
                else if (IsEditScript)
                {
                    // ...
                }

                loadingBehavior = false;
            }
        }

        private void SaveBehaviorProps()
        {
            if (!loadingBehavior)
            {
                curBehav.Config.Name = TextBoxX_BehavName.Text.Trim();
                curBehav.CollisionPointer = ValueFromText(textBoxX_BehavColPtr.Text);
                curBehav.EnableCollisionPointer = checkBoxX_BehavEnableColPtr.Checked;
                Timer_PropsChanged.Stop(); Timer_PropsChanged.Start();
            }
        }

        private bool SaveBehaviorScript()
        {
            // ...
            return false;
        }

        // G U I

        private void BehaviorBankManager_Shown(object sender, EventArgs e)
        {
            LoadBehaviors(true);
            LoadBehaviors(false);
        }

        private void AdvTree_Behaviors_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            if (e.Node?.Tag is Behavior)
                curBehav = (Behavior)e.Node.Tag;
            else
                curBehav = null;
            LoadBehavior();
        }

        private void TabControl_Behav_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
        {
            LoadBehavior();
        }

        private void TabControl_Behav_SelectedTabChanging(object sender, TabStripTabChangingEventArgs e)
        {
        }

        private void ButtonX_SaveScript_Click(object sender, EventArgs e)
        {
            bool res = SaveBehaviorScript();
            highlighter_Script.SetHighlightColor(RichTextBoxEx_Script, res ? eHighlightColor.None : eHighlightColor.Red);
        }

        private void CheckBoxX_BehavEnableColPtr_CheckedChanged(object sender, EventArgs e)
        {
            textBoxX_BehavColPtr.Enabled = checkBoxX_BehavEnableColPtr.Checked;
            SaveBehaviorProps();
        }

        private void TextBoxX_BehavColPtr_TextChanged(object sender, EventArgs e)
        {
            SaveBehaviorProps();
        }

        private void TextBoxX_BehavName_TextChanged(object sender, EventArgs e)
        {
            SaveBehaviorProps();
        }
    }
}