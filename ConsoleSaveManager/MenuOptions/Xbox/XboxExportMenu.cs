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

namespace ConsoleSaveManager.MenuOptions.Xbox
{
    public partial class XboxExportMenu : Form
    {
        public XboxExportMenu()
        {
            InitializeComponent();

            var properties = Properties.Settings.Default;
            exportMenuTextBox.Text = properties.ExportedSavesPath;
        }

        private void ButtonBackXboxExportMenu_Click(object sender, EventArgs e)
        {
            XboxMenu xboxMenu = new XboxMenu();
            xboxMenu.Show();
            this.Hide();
        }

        private void ExportStart_Click(object sender, EventArgs e)
        {
            ExportSave();
        }

        private async void ExportSave()
        {
            var properties = Properties.Settings.Default;
            try
            {
                string batDir = string.Format(Application.StartupPath + @"\scripts\");
                var path = Application.StartupPath + @"\locations\xbExportLocation.txt";
                string text = properties.ExportedSavesPath;
                File.WriteAllText(path, text);

                await Task.Delay(1000);

                Process proc = new Process();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "xbexport.bat";
                proc.Start();
                proc.WaitForExit();

                await Task.Delay(2000);
                MessageBox.Show("Export completed!");
                await Task.Delay(2000);

            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace.ToString());
            }
        }
    }
}
