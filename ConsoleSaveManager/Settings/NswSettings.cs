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

namespace ConsoleSaveManager.Settings
{
    public partial class NswSettings : Form
    {
        public NswSettings()
        {
            InitializeComponent();
        }

        public void GetSettings()
        {
            var properties = Properties.Settings.Default;
            TextBoxSavedNswPath.Text = properties.NswExportedSavePath;
        }

        public void SaveSettings()
        {
            var properties = Properties.Settings.Default;
            var nswSavePathValue = TextBoxNswSaveLocation.Text;
            properties.NswExportedSavePath = nswSavePathValue;

            TextBoxSavedNswPath.Text = properties.NswExportedSavePath;

            var savepath = Application.StartupPath + @"\locations\nswsavepath.txt";
            File.WriteAllText(savepath, properties.NswExportedSavePath);

            Properties.Settings.Default.Save();
        }
        private void NswSettings_Load(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void ButtonNswSettingsSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void ButtonNswBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Choose where to save the save file!"
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxNswSaveLocation.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonBackXboxSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
