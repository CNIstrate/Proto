using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;

namespace Save_Manager.SettingsForms
{
    public partial class SwitchSettingsForm : Form
    {
        public SwitchSettingsForm()
        {
            InitializeComponent();

            SavePath.Text = General.switchExportPath;

            ActiveControl = ExportToTitle;
        }

        private void ChangePath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFolder = new CommonOpenFileDialog
            {
                InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}",
                AllowNonFileSystemItems = true,
                Multiselect = false,
                IsFolderPicker = true,
                Title = "Choose in which folder should the save data be exported"
            };

            if (openFolder.ShowDialog() != CommonFileDialogResult.Ok)
                return;

            while (openFolder.FileName.ToString().Contains("::{"))
            {
                MessageBox.Show("Virtual folders cannot be used for file management.", "Save Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (openFolder.ShowDialog() != CommonFileDialogResult.Ok)
                    return;
            }

            SavePath.Text = openFolder.FileName.ToString();

            openFolder.Dispose();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(SavePath.Text))
                    Directory.CreateDirectory(SavePath.Text);

                General.switchExportPath = SavePath.Text;
                General.SaveSettings();

                Dispose();
            }
            catch
            {
                MessageBox.Show("Directory can't be generated in the selected location.", "Save Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
