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

namespace ConsoleSaveManager.MenuOptions.NSW
{
    public partial class NswImportMenu : Form
    {
        public NswImportMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ImportSave();
        }

        private async void ImportSave()
        {
            try
            {
                string batDir = string.Format(Application.StartupPath + @"\scripts\");

                await Task.Delay(1000);

                Process proc = new Process();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "nswimport.bat";
                proc.Start();
                proc.WaitForExit();

            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace.ToString());
            }
        }

        private void ButtomImportBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Choose where to save the save file!"
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TextNswImportPath.Text = folderBrowserDialog.SelectedPath;
                var path = Application.StartupPath + @"\locations\nswsaveimportpath.txt";
                string text = TextNswImportPath.Text;
                File.WriteAllText(path, text);
            }
        }

        private void ButtonBackNswMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
