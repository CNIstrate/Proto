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
    public partial class NswMenu : Form
    {
        public NswMenu()
        {
            InitializeComponent();
        }

        private void ButtonBackXboxSettings_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private async void ExportSave()
        {
            try
            {
                string batDir = string.Format(Application.StartupPath + @"\scripts\");

                await Task.Delay(1000);

                Process proc = new Process();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "nswexport.bat";
                proc.Start();
                proc.WaitForExit();

            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace.ToString());
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            NswImportMenu nswImportMenu = new NswImportMenu();
            nswImportMenu.Show();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportSave();
        }
    }
}
