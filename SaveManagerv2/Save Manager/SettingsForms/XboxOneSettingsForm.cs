using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_Manager.SettingsForms
{
    public partial class XboxOneSettingsForm : Form
    {
        public XboxOneSettingsForm()
        {
            InitializeComponent();

            SavePath.Text = General.xboxExportPath;

            if (General.SCID == "0")
                SCID.Text = string.Empty;



            ActiveControl = ExportToTitle;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string tempSCID = SCID.Text.Replace(" ", "").Replace("\t", "");
            string tempIP = XboxIP.Text.Replace(" ", "").Replace("\t", "");

            if (tempSCID == string.Empty || tempIP == string.Empty || AppxManifestPath.Text == string.Empty)
            {
                MessageBox.Show("All fields are required.", "Save Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void ChangePathButton_Click(object sender, EventArgs e)
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

        private void XboxIPBoxPadding_MouseDown(object sender, MouseEventArgs e) => XboxIP.Focus();

        private void SCIDBoxPadding_MouseDown(object sender, MouseEventArgs e) => SCID.Focus();
    }
}
