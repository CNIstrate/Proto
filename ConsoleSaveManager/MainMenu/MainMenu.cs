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

namespace ConsoleSaveManager
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            string subPath = @"C:\installpath\"; // your code goes here

            bool exists = Directory.Exists(subPath);

            if (!exists)
            {
                Directory.CreateDirectory(subPath);
                var path = @"C:\installpath\installpath.txt";
                string text = Application.StartupPath;
                File.WriteAllText(path, text);
            }
            else
            {
                var path = @"C:\installpath\installpath.txt";
                string text = Application.StartupPath;
                File.WriteAllText(path, text);
            }

            

        }

        private void XboxButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            XboxMenu xboxMenu = new XboxMenu();
            xboxMenu.Show();
        }

        private void PS4Button_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Feature yet to be implemented! :D");
        }

        private void NSWButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature yet to be implemented! :D");
            
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            XboxSettings xboxSettingsMenu = new XboxSettings();
            xboxSettingsMenu.Show();
        }
    }
}
