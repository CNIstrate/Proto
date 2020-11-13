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
    public partial class XboxImportMenu : Form
    {
        public XboxImportMenu()
        {
            InitializeComponent();
        }

        private void ButtonBackXboxSettings_Click(object sender, EventArgs e)
        {
            XboxMenu xboxMenu = new XboxMenu();
            xboxMenu.Show();
            this.Hide();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Locate AppxManifest.xml file of your Xbox Project",
                    InitialDirectory = Application.StartupPath + @"\saves\xbox\",
                    Filter = "All files (*.xml*)|*.xml*",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    importMenuTextBox.Text = openFileDialog.FileName;
                    
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace.ToString());
            }
        }

        private void ImportStart_Click(object sender, EventArgs e)
        {
            ImportSave();
        }

        private async void ImportSave()
        {
            try
            {
                string batDir = string.Format(Application.StartupPath + @"\scripts\");
                var path = Application.StartupPath + @"\locations\xbImportLocation.txt";
                string text = importMenuTextBox.Text;
                File.WriteAllText(path, text);

                await Task.Delay(1000);

                Process proc = new Process();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = "xbimport.bat";
                proc.Start();
                proc.WaitForExit();

                await Task.Delay(2000);
                MessageBox.Show("Import completed!");
                await Task.Delay(2000);

            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace.ToString());
            }
        }
    }
}
