using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Validator;
using SM64_ROM_Manager.My.Resources;
using SM64Lib;
using SM64Lib.Behaviors;
using SM64Lib.Behaviors.Script;
using SM64Lib.Data;
using Z.Collections.Extensions;
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

        private BehaviorBank bank;
        private Behavior curBehav = null;
        private bool loadingBehavior = false;
        private Timer Timer_PropsChanged;

        // C o n s t r u c t o r

        public BehaviorBankManager(BehaviorBank bank)
        {
            this.bank = bank;

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

                foreach (var behav in bank.Behaviors)
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

        private Node FindNode(Behavior behav)
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

            return n;
        }

        private void UpdateNode(Behavior behav)
        {
            Node n = FindNode(behav);
            if (n is object)
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
                    RichTextBoxEx_Script.Text = GetScriptAsString(curBehav.Script);
                }

                ButtonItem_RemoveBehav.Enabled = !curBehav.Config.IsVanilla;
                bar1.Refresh();

                loadingBehavior = false;
            }
        }

        private static string GetScriptAsString(Behaviorscript script)
        {
            var sw = new StringWriter();
            
            for (int i = 0; i < script.Count; i++)
            {
                var cmd = (BehaviorscriptCommand)script[i];
                
                if (i > 0)
                    sw.WriteLine();

                byte[] cmdArr = cmd.ToArray();
                for (int i1 = 0; i1 < cmdArr.Length; i1++)
                {
                    if (i1 > 0) sw.Write(" ");
                    sw.Write(cmdArr[i1].ToString("X2"));
                }
            }

            return sw.ToString();
        }

        private static bool BuildScriptWithString(Behavior behav, string str)
        {
            var success = true;
            var scriptBytes = new List<byte>();

            // Get all single bytes
            using (var sr = new StringReader(str))
            {
                while (success && sr.Peek() != -1)
                {
                    var line = sr.ReadLine();
                    var bytes = line?.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (bytes is object && bytes.Any())
                    {
                        foreach (var @byte in bytes)
                        {
                            var @byteTrimed = @byte.Trim();
                            if (!string.IsNullOrEmpty(@byteTrimed))
                            {
                                if (byte.TryParse(@byteTrimed, System.Globalization.NumberStyles.HexNumber, null, out var b))
                                    scriptBytes.Add(b);
                                else
                                    success = false;
                            }
                        }
                    }
                }
            }

            if (success && scriptBytes.Count % 4 == 0 && (!behav.Config.IsVanilla || behav.Config.FixedLength >= scriptBytes.Count))
            {
                // Read script
                using (var scriptData = new BinaryStreamData(new MemoryStream(scriptBytes.ToArray())))
                    success = behav.Script.Read(scriptData, 0);
            }
            else
                success = false;

            return success;
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
            return BuildScriptWithString(curBehav, RichTextBoxEx_Script.Text);
        }

        private void RemoveBehavior(Behavior behav)
        {
            Node n = FindNode(behav);

            if (n is object)
            {
                n.Remove();
                bank.Behaviors.RemoveIfContains(behav);
                if (curBehav == behav) curBehav = null;
            }

            
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
            highlighter_Script.SetHighlightColor(RichTextBoxEx_Script, eHighlightColor.None);
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
            if (res)
                curBehav.ParseScript();
            else
                MessageBoxEx.Show(this, BehaviorBankManagerLangRes.Msg_ErrorCompilingScript, BehaviorBankManagerLangRes.Msg_ErrorCompilingScriptTitel, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ButtonItem_AddBehav_Click(object sender, EventArgs e)
        {

        }

        private void ButtonItem_RemoveBehav_Click(object sender, EventArgs e)
        {
            if (curBehav is object && !curBehav.Config.IsVanilla && MessageBoxEx.Show(this, BehaviorBankManagerLangRes.Msg_RemoveBehavior, BehaviorBankManagerLangRes.Msg_RemoveBehaviorTitel, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                RemoveBehavior(curBehav);
        }
    }
}