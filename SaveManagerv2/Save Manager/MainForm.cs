using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_Manager
{
    public partial class MainForm : Form
    {
        private void LoadSettings()
        {
            if (File.Exists(General.installationPath + @"\Settings\UserSettings"))
            {
                General.switchExportPath = File.ReadLines(General.installationPath + @"\Settings\UserSettings").ElementAtOrDefault(0);

                General.xboxIP = File.ReadLines(General.installationPath + @"\Settings\UserSettings").ElementAtOrDefault(1);
                General.SCID = File.ReadLines(General.installationPath + @"\Settings\UserSettings").ElementAtOrDefault(2);
                General.appxManifestPath = File.ReadLines(General.installationPath + @"\Settings\UserSettings").ElementAtOrDefault(3);
                General.xboxExportPath = File.ReadLines(General.installationPath + @"\Settings\UserSettings").ElementAtOrDefault(4);
            }
            else
            {
                File.WriteAllText(General.installationPath + @"\Settings\UserSettings", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Save Manager\Switch" + Environment.NewLine);

                File.AppendAllText(General.installationPath + @"\Settings\UserSettings", "0" + Environment.NewLine);
                File.AppendAllText(General.installationPath + @"\Settings\UserSettings", "0" + Environment.NewLine);
                File.AppendAllText(General.installationPath + @"\Settings\UserSettings", "0" + Environment.NewLine);
                File.AppendAllText(General.installationPath + @"\Settings\UserSettings", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Save Manager\Xbox One");

                LoadSettings();
            }
        }

        public MainForm()
        {
            InitializeComponent();

            General.GetInstallationPath();

            VersionLabel.Text = General.versionNumber;

            LoadSettings();
        }

        private void XboxSettingsButton_Click(object sender, EventArgs e)
        {
            Hide();

            SettingsForms.XboxOneSettingsForm xboxOneMenu = new SettingsForms.XboxOneSettingsForm();
            var waitForForm = xboxOneMenu.ShowDialog();
            xboxOneMenu.Dispose();

            Show();
        }

        private void SwitchSettingsButton_Click(object sender, EventArgs e)
        {
            Hide();

            SettingsForms.SwitchSettingsForm switchMenu = new SettingsForms.SwitchSettingsForm();
            var waitForForm = switchMenu.ShowDialog();
            switchMenu.Dispose();

            Show();
        }

        private void XboxSavesButtton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(General.xboxExportPath);

            Process.Start(General.xboxExportPath);
        }

        private void SwitchSavesButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(General.switchExportPath);

            Process.Start(General.switchExportPath);
        }

        private void XboxExportButtton_Click(object sender, EventArgs e)
        {
            if (General.xboxIP == "0" || General.SCID == "0" || General.appxManifestPath == "0")
            {
                Hide();

                SettingsForms.XboxOneSettingsForm xboxOneMenu = new SettingsForms.XboxOneSettingsForm();
                var waitForForm = xboxOneMenu.ShowDialog();
                xboxOneMenu.Dispose();

                Show();
            }

            if (General.xboxIP == "0" || General.SCID == "0" || General.appxManifestPath == "0")
                return;

            // Run Script
        }
    }
}
