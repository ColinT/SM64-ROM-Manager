using System;
using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using System.Windows.Forms;
using global::DevComponents.AdvTree;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::Microsoft.WindowsAPICodePack.Dialogs;
using Z.Collections.Extensions;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class UpdateManagerWindow
    {

        // C o n s t a n t s

        private const string FILTER_UPDATEINFO_CONFIGURATION = "Update-Info-Konfiguration (*.udic)|*.udic";

        // F i e l d s

        private string curProjectFilePath;
        private UpdateServerManager manager = null;

        // C o n s t r u c t o r s

        public UpdateManagerWindow()
        {
            this.Shown += EditorWindow_Shown;
            this.Load += UpdateManagerWindow_Load;
            InitializeComponent();
            UpdateAmbientColors();
            SetEnabledUiControls(false);
        }

        // F e a t u r e s

        private void SetEnabledUiControls(bool enabled, bool setProjectOptionsAlwayToTrue = false)
        {
            ribbonBar_Options.Enabled = enabled || setProjectOptionsAlwayToTrue;
            ribbonBar_Tools.Enabled = enabled;
            ribbonBar_UpdateConfiguration.Enabled = enabled;
            ribbonPanel_Package.Enabled = Enabled;
        }

        private void CreateNewProject(string filePath)
        {
            var oldProject = General.CurProject;
            General.CurProject = new UpdateProject();
            if (My.MyProject.Forms.UpdateServerInfoEditor.ShowDialog() == DialogResult.OK)
            {
                curProjectFilePath = filePath;
                SaveProject(curProjectFilePath);
                LoadManager();
            }
            else
                General.CurProject = oldProject;
        }

        private void OpenProject(string filePath)
        {
            curProjectFilePath = filePath;
            General.CurProject = UpdateProject.Load(filePath);
            LoadManager();
        }

        private void SaveProject(string filePath)
        {
            General.CurProject.Save(filePath);
        }

        private void LoadManager()
        {
            try
            {
                manager = new UpdateServerManager(General.CurProject.UpdateServerConfig);
                manager.LoadInfoFromServer();

                LoadPackageList();
                LoadUpdateInstallerInfos();

                SetEnabledUiControls(true);
            }
            catch (Exception)
            {
                MessageBoxEx.Show(this, "Ein Fehler ist aufgetreten beim laden des Servers.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetEnabledUiControls(false, true);
            }
        }

        private void LoadPackageList()
        {
            ListViewItem firstItem = null;

            ListViewEx_Packages.BeginUpdate();
            ListViewEx_Packages.Items.Clear();

            foreach (var pkg in manager.UpdateInfo.Packages)
            {
                var item = new ListViewItem(new string[]
                {
                    pkg.Name,
                    pkg.Version.Version.ToString(),
                    pkg.Version.Channel.ToString(),
                    pkg.Version.Build.ToString(),
                    "Ja"
                })
                {
                    Tag = pkg
                };

                ListViewEx_Packages.Items.Add(item);

                if (firstItem == null)
                    firstItem = item;
            }

            ListViewEx_Packages.EndUpdate();

            if (firstItem is object)
                firstItem.Selected = true;
        }

        private void LoadUpdateInstallerInfos()
        {
            TextBoxX_UpdateInstallerDownloadUrl.Text = manager.UpdateInfo.UpdateInstallerLink;
        }

        // G u i

        private void SuperTabControl1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
        }

        private void EditorWindow_Shown(object sender, EventArgs e)
        {
        }

        private void UpdateManagerWindow_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                try
                {
                    OpenProject(args[1]);
                }
                catch (Exception) { }
            }
        }

        private void ButtonItem_NewProject_Click(object sender, EventArgs e)
        {
            var sfd_updateadministration_upa = new SaveFileDialog()
            {
                Filter = "Update Project Files (*.upa)|*.upa"
            };
            if (sfd_updateadministration_upa.ShowDialog() == DialogResult.OK)
            {
                CreateNewProject(sfd_updateadministration_upa.FileName);
            }
        }

        private void ButtonItem_OpenProject_Click(object sender, EventArgs e)
        {
            var ofd_updateadministration_upa = new OpenFileDialog()
            {
                Filter = "Update Project Files (*.upa)|*.upa"
            };
            if (ofd_updateadministration_upa.ShowDialog() == DialogResult.OK)
            {
                OpenProject(ofd_updateadministration_upa.FileName);
            }
        }

        private void ButtonItem_SaveProject_Click(object sender, EventArgs e)
        {
            SaveProject(curProjectFilePath);
        }

        private void ButtonItem_ProjectOptions_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.UpdateServerInfoEditor.ShowDialog();
            LoadManager();
        }

        private void ButtonItem_UploadUpdateConfiguration_Click(object sender, EventArgs e)
        {
            manager.SaveInfoToServer();
        }

        private void ButtonItem_ExportUpdateConfiguration_Click(object sender, EventArgs e)
        {
            var ofd_UpdateAdministration_UpdateConfiguration = new OpenFileDialog()
            {
                Filter = FILTER_UPDATEINFO_CONFIGURATION
            };
            if (ofd_UpdateAdministration_UpdateConfiguration.ShowDialog() == DialogResult.OK)
                manager.SaveInfoToFile(ofd_UpdateAdministration_UpdateConfiguration.FileName);
        }

        private void ButtonItem_OpenPackageCreationDialog_Click(object sender, EventArgs e)
        {
            var frm = new PackageCreationDialog();
            frm.Show();
        }

        private void ButtonItem_CreateAndUploadPackage_Click(object sender, EventArgs e)
        {

        }

        private void ButtonItem_UploadExistingPackage_Click(object sender, EventArgs e)
        {
            //var frm = new ApplicationVersionInput();
            //frm.ShowDialog();
        }

        private void ButtonItem_RemovePackage_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxX_UpdateInstallerDownloadUrl_TextChanged(object sender, EventArgs e)
        {
            manager.UpdateInfo.UpdateInstallerLink = TextBoxX_UpdateInstallerDownloadUrl.Text.Trim();
        }

        private void ListViewEx_Packages_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ButtonItem_PostMsgInDiscord_Click(object sender, EventArgs e)
        {

        }
    }
}