using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleSaveManager.Settings
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void XboxSettingsButton_Click(object sender, EventArgs e)
        {
            XboxSettings xboxSettings = new XboxSettings();
            xboxSettings.Show();
        }

        private void ButtonBackNswSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NSWSettingsButton_Click(object sender, EventArgs e)
        {
            NswSettings nswSettings = new NswSettings();
            nswSettings.Show();
        }

        private void PS4SettingsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature yet to be implemented!");
        }
    }
}
