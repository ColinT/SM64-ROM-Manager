using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SM64_ROM_Manager.PatchScripts;
using SM64Lib.Objects.ObjectBanks;

namespace SM64_ROM_Manager
{
    public partial class CustomObjectsDatabaseViewer : OfficeForm
    {
        // F i e l d s

        private readonly TweakDatabaseManager databaseManager;
        private IEnumerable<TweakDatabaseSyncFile> syncFiles = null;

        // C o n s t r u c t o r

        public CustomObjectsDatabaseViewer()
        {
            // Database
            var dbPref = TweakDatabasePreferences.Load(Path.Combine(Publics.General.MyDataPath, @"Other\Object Database Preferences.json"));
            databaseManager = new TweakDatabaseManager(dbPref);

            // Components
            InitializeComponent();
            UpdateAmbientColors();
        }

        // F e a t u r e s

        private async Task<IEnumerable<CustomObjectImport>> LoadLocalImports()
        {
            var tasks = new List<Task<CustomObjectImport>>();
            var imports = new List<CustomObjectImport>();
            var localPath = Publics.General.MyCustomObjectsPath;

            foreach (var filePath in Directory.GetFiles(localPath, "*.rmobj", SearchOption.AllDirectories))
                tasks.Add(Task.Run(() => CustomObjectCollection.LoadImport(filePath)));

            foreach (var task in tasks)
                imports.Add(await task);

            return imports;
        }

        private async Task LoadImports()
        {
            var imports = await LoadLocalImports();

            itemListBox_CustomObjectFiles.BeginUpdate();
            itemListBox_CustomObjectFiles.Items.Clear();

            foreach (var import in imports)
            {
                var item = new ButtonItem
                {
                    Text = import.Name,
                    Tag = import
                };
                itemListBox_CustomObjectFiles.Items.Add(item);
            }

            itemListBox_CustomObjectFiles.EndUpdate();
            if (itemListBox_CustomObjectFiles.Items.Count > 0)
                itemListBox_CustomObjectFiles.SelectedIndex = 0;
        }

        private void LoadObjects(CustomObjectImport import)
        {
            advTree_CustomObjects.BeginUpdate();
            advTree_CustomObjects.Nodes.Clear();

            if (import is object)
            {
                foreach (var customObject in import.CustomObjects)
                {
                    var n = new Node
                    {
                        Text = customObject.Name,
                        Tag = customObject,
                        Expanded = true
                    };
                    n.Cells.Add(new Cell(!customObject.ModelProps.UseCustomModelID && customObject.ModelProps.Model is object ? "Yes" : "No"));
                    advTree_CustomObjects.Nodes.Add(n);
                }
            }

            advTree_CustomObjects.EndUpdate();
        }

        private void LoadObjectPorps(CustomObject customObject)
        {
            var isNull = customObject == null;
            textBoxX_Description.Text = isNull ? string.Empty : customObject.Description;
        }

        private CustomObjectImport GetSelectedImport()
        {
            return itemListBox_CustomObjectFiles.SelectedItem?.Tag as CustomObjectImport;
        }

        private async void SearchUpdates()
        {
            var localPath = Path.Combine(Publics.General.MyCustomObjectsPath, databaseManager.Preferences.CategoryPaths[TweakDatabaseCategories.Reviewed]);
            syncFiles = await databaseManager.CheckForUpdates(localPath);
            if (syncFiles is object && syncFiles.Any())
                warningBox1.Visible = true;
        }

        private async Task DoUpdate()
        {
            if (syncFiles != null && syncFiles.Any())
            {
                await databaseManager.Update(syncFiles);
                warningBox1.Visible = false;
            }
        }

        // G u i

        private async void CustomObjectsDatabaseViewer_Shown(object sender, EventArgs e)
        {
            CirProg.Start();
            await LoadImports();
            CirProg.Stop();
            SearchUpdates();
        }

        private void CustomObjectsDatabaseViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            CirProg.Stop();
        }

        private async void WarningBox1_OptionsClick(object sender, EventArgs e)
        {
            CirProg.Start();
            await DoUpdate();
            await LoadImports();
            CirProg.Stop();
        }

        private void AdvTree1_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            LoadObjectPorps(e.Node?.Tag as CustomObject);
        }

        private void ItemListBox_CustomObjectFiles_SelectedItemChanged(object sender, EventArgs e)
        {
            LoadObjects(GetSelectedImport());
        }
    }
}