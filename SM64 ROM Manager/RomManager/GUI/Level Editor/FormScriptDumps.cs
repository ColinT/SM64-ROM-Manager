using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SM64Lib.Geolayout.Script;
using static SM64Lib.TextValueConverter.TextValueConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SM64_ROM_Manager.LevelEditor
{
    public partial class FormScriptDumps : RibbonForm
    {

        // F i e l d s

        private readonly Dictionary<byte, Geolayoutscript> dicGeolayoutScripts = new Dictionary<byte, Geolayoutscript>();

        // D e f a u l t   N o d e s

        private Node nGeolayoutScripts = new Node()
        {
            Name = "nGeoScripts",
            Text = "Geolayouts",
            Expanded = true
        };

        // C o n s t r u c t o r

        public FormScriptDumps()
        {
            InitializeComponent();
            UpdateAmbientColors();
            ScriptTree.Nodes.Add(nGeolayoutScripts);
        }

        // F e a t u r e s

        private void AddSriptNode(object tag, string text, string name, Node parent)
        {
            var n = new Node()
            {
                Text = text,
                Tag = tag
            };
            parent.Nodes.Add(n);
        }

        public void AddGeolayoutScript(byte modelID, Geolayoutscript script)
        {
            dicGeolayoutScripts.Add(modelID, script);
            AddSriptNode(
                modelID,
                $"{TextFromValue(modelID, charCount:3)} ({TextFromValue(script.FirstOrDefault()?.RomAddress ?? 0)})",
                nGeolayoutScripts.Text + modelID.ToString(),
                nGeolayoutScripts);
        }

        private void ShowGeolayoutScript(byte modelID)
        {
            var sw = new StringWriter();

            foreach (GeolayoutCommand command in dicGeolayoutScripts[modelID])
            {
                sw.WriteLine($"{command.ToString()}");
            }

            RichTextBoxEx_Script.Text = sw.ToString();
            sw.Close();
        }

        // G U I

        private void ScriptTree_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            if (e.Node.Parent == nGeolayoutScripts && e.Node.Tag is byte)
            {
                ShowGeolayoutScript((byte)e.Node.Tag);
            }
        }

    }
}
