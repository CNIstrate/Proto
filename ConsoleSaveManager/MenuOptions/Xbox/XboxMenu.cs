using ConsoleSaveManager.MenuOptions.Xbox;
using System;
using System.Windows.Forms;

namespace ConsoleSaveManager
{
    public partial class XboxMenu : Form
    {
        public XboxMenu()
        {
            InitializeComponent();
            ToolTip toolTipExport = new ToolTip();
            ToolTip toolTipImport = new ToolTip();
            ToolTip toolTipDelete = new ToolTip();
            toolTipExport.SetToolTip(ExportButton, "Export your save data from your console to your PC!");
            toolTipImport.SetToolTip(ImportButton, "Import your save data from your PC to your console!");
            toolTipDelete.SetToolTip(DeleteButton, "Delete the save data from your console!");
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            XboxExportMenu exportMenu = new XboxExportMenu();
            exportMenu.Show();
            this.Hide();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            XboxImportMenu importMenu = new XboxImportMenu();
            importMenu.Show();
            this.Hide();
        }

        private void ButtonBackXboxMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
