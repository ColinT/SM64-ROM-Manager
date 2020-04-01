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
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class UpdateManagerWindow
    {

        // C o n s t a n t s

        private const string FILTER_UPDATEINFO_CONFIGURATION = "Update-Info-Konfiguration (*.udic)|*.udic";
        private const string FILTER_UPDATEPACKAGE = "ZIP-Archiv (*.zip)|*.zip";

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

        private async Task CreateNewProject(string filePath)
        {
            var oldProject = General.CurProject;
            General.CurProject = new UpdateProject();
            if (My.MyProject.Forms.UpdateServerInfoEditor.ShowDialog() == DialogResult.OK)
            {
                curProjectFilePath = filePath;
                SaveProject(curProjectFilePath);
                await LoadManager();
            }
            else
                General.CurProject = oldProject;
        }

        private async Task OpenProject(string filePath)
        {
            curProjectFilePath = filePath;
            General.CurProject = UpdateProject.Load(filePath);
            await LoadManager();
        }

        private void SaveProject(string filePath)
        {
            General.CurProject.Save(filePath);
        }

        private async Task LoadManager()
        {
            bool hasError;

            try
            {
                manager = new UpdateServerManager(General.CurProject.UpdateServerConfig);

                if (await manager.LoadInfoFromServer())
                {
                    await LoadPackageList();
                    LoadUpdateInstallerInfos();

                    hasError = false;
                }
                else
                    hasError = true;
            }
            catch (Exception)
            {
                hasError = true;
            }

            if (hasError)
            {
                MessageBoxEx.Show(this, "Ein Fehler ist aufgetreten beim laden des Servers.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetEnabledUiControls(false, true);
            }
            else
                SetEnabledUiControls(true);
        }

        private async Task LoadPackageList()
        {
            ListViewItem firstItem = null;

            ListViewEx_Packages.BeginUpdate();
            ListViewEx_Packages.Items.Clear();

            foreach (var pkgVersion in await manager.GetUpdatePackagesList())
            {
                var item = new ListViewItem(new string[]
                {
                    manager.GetPackageDescription(pkgVersion).name,
                    pkgVersion.Version.ToString(),
                    pkgVersion.Channel.ToString(),
                    pkgVersion.Build.ToString(),
                    "Ja"
                })
                {
                    Tag = pkgVersion
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

        private ApplicationVersion GetSelectedPackageVersion()
        {
            var items = ListViewEx_Packages.SelectedItems;
            if (items.Count > 0)
                return (ApplicationVersion)items[0].Tag;
            else
                return null;
        }

        private async Task<bool> UploadPackage(string filePath)
        {
            var success = false;
            var resVersion = EditApplicationVersion();

            if (!resVersion.canceled)
            {
                if (await manager.UploadPackage(filePath, resVersion.newVersion))
                {
                    success = true;
                }
            }

            return success;
        }

        // G u i

        private void SuperTabControl1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
        }

        private void EditorWindow_Shown(object sender, EventArgs e)
        {
        }

        private async void UpdateManagerWindow_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                try
                {
                    await OpenProject(args[1]);
                }
                catch (Exception) { }
            }
        }

        private async void ButtonItem_NewProject_Click(object sender, EventArgs e)
        {
            var sfd_updateadministration_upa = new SaveFileDialog()
            {
                Filter = "Update Project Files (*.upa)|*.upa"
            };
            if (sfd_updateadministration_upa.ShowDialog() == DialogResult.OK)
            {
                await CreateNewProject(sfd_updateadministration_upa.FileName);
            }
        }

        private async void ButtonItem_OpenProject_Click(object sender, EventArgs e)
        {
            var ofd_updateadministration_upa = new OpenFileDialog()
            {
                Filter = "Update Project Files (*.upa)|*.upa"
            };
            if (ofd_updateadministration_upa.ShowDialog() == DialogResult.OK)
            {
                await OpenProject(ofd_updateadministration_upa.FileName);
            }
        }

        private void ButtonItem_SaveProject_Click(object sender, EventArgs e)
        {
            SaveProject(curProjectFilePath);
        }

        private async void ButtonItem_ProjectOptions_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.UpdateServerInfoEditor.ShowDialog();
            await LoadManager();
        }

        private async void ButtonItem_UploadUpdateConfiguration_Click(object sender, EventArgs e)
        {
            await manager.SaveInfoToServer();
        }

        private async void ButtonItem_ExportUpdateConfiguration_Click(object sender, EventArgs e)
        {
            var ofd_UpdateAdministration_UpdateConfiguration = new OpenFileDialog()
            {
                Filter = FILTER_UPDATEINFO_CONFIGURATION
            };
            if (ofd_UpdateAdministration_UpdateConfiguration.ShowDialog() == DialogResult.OK)
                await manager.SaveInfoToFile(ofd_UpdateAdministration_UpdateConfiguration.FileName);
        }

        private void ButtonItem_OpenPackageCreationDialog_Click(object sender, EventArgs e)
        {
            var frm = new PackageCreationDialog();
            frm.Show();
        }

        private async void ButtonItem_CreateAndUploadPackage_Click(object sender, EventArgs e)
        {
            var frm = new PackageCreationDialog(true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (await UploadPackage(frm.TempPackageFilePath))
                    await LoadPackageList();
            }
        }

        private async void ButtonItem_UploadExistingPackage_Click(object sender, EventArgs e)
        {
            var ofd_UpdateAdministration_UpdatePackage = new OpenFileDialog()
            {
                Filter = FILTER_UPDATEPACKAGE
            };

            if (ofd_UpdateAdministration_UpdatePackage.ShowDialog() == DialogResult.OK)
            {
                if(await UploadPackage(ofd_UpdateAdministration_UpdatePackage.FileName))
                    await LoadPackageList();
            }
        }

        private async void ButtonItem_RemovePackage_Click(object sender, EventArgs e)
        {
            var version = GetSelectedPackageVersion();
            if (await manager.DeletePackage(version))
                await LoadPackageList();
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

        private async void ButtonItem_ChangeVersion_Click(object sender, EventArgs e)
        {
            var version = GetSelectedPackageVersion();
            var (newVersion, canceled) = EditApplicationVersion(version);

            if (!canceled)
            {
                if (await manager.ChangePackageVersion(version, newVersion))
                    await LoadPackageList();
            }
                
        }

        private (ApplicationVersion newVersion, bool canceled) EditApplicationVersion(ApplicationVersion inputVersion = default)
        {
            var frm = new ApplicationVersionInput()
            {
                Version = inputVersion.Version,
                Channel = inputVersion.Channel,
                Build = inputVersion.Build
            };

            if (frm.ShowDialog() == DialogResult.OK)
                return (new ApplicationVersion(frm.Version, frm.Build, frm.Channel), false);
            else
                return (inputVersion, true);
        }

        private async void ButtonItem_EditDescription_Click(object sender, EventArgs e)
        {
            var version = GetSelectedPackageVersion();
            var desc = manager.GetPackageDescription(version);

            var frm = new PackageDescriptionEditor()
            {
                Titel = desc.name,
                Description = desc.description
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                manager.SetPackageDescription(version, frm.Titel, frm.Description);
                await LoadPackageList();
            }
        }
    }
}