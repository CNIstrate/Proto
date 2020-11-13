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
using System.Xml;

namespace ConsoleSaveManager
{
    public partial class XboxSettings : Form
    {
        public XboxSettings()
        {
            InitializeComponent();
        }

        private void ButtonBackXboxSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        public void GetSettings()
        {
            var properties = Properties.Settings.Default;
            LabelSavedIP.Text = properties.ConsoleIP;
            LabelSavedAppxManifest.Text = properties.AppxManifestPath;
            LabelSavedExported.Text = properties.ExportedSavesPath;
            LabelSavedSCID.Text = properties.SCIDValue;
        }

        public void SaveSettings()
        {
            var properties = Properties.Settings.Default;

            var consoleIPValue = TextBoxConsoleIP.Text;
            var appxManifestPathValue = TextBoxAppxManifestFile.Text;
            var exportedSavesPathValue = TextBoxExportedSavesPath.Text;

            properties.ConsoleIP = consoleIPValue;
            properties.AppxManifestPath = appxManifestPathValue;
            properties.ExportedSavesPath = exportedSavesPathValue;

            LabelSavedIP.Text = consoleIPValue;
            LabelSavedAppxManifest.Text = appxManifestPathValue;
            LabelSavedExported.Text = exportedSavesPathValue;

            var ipfilepath = Application.StartupPath + @"\locations\xbconsoleip.txt";
            File.WriteAllText(ipfilepath, properties.ConsoleIP);

            var exportSavePath = Application.StartupPath + @"\locations\xbExportLocation.txt";
            File.WriteAllText(exportSavePath, properties.ExportedSavesPath);

            Properties.Settings.Default.Save();
        }

        public void ResetSettings()
        {
            var properties = Properties.Settings.Default;

            properties.ConsoleIP = "none";
            properties.AppxManifestPath = "none";
            properties.ExportedSavesPath = "none";
            properties.SCIDValue = "none";

            LabelSavedIP.Text = properties.ConsoleIP;
            LabelSavedAppxManifest.Text = properties.AppxManifestPath;
            LabelSavedExported.Text = properties.ExportedSavesPath;
            LabelSavedSCID.Text = properties.SCIDValue;
        }

        public void GetSCID()
        {

            string fileName = Application.StartupPath + @"\AppxManifest\scid.txt";
            try
            {

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(TextBoxAppxManifestFile.Text);

                    XmlNodeList nodes = doc.GetElementsByTagName("mx:XboxLive");

                    //loop through each node in the XML
                    foreach (XmlNode node in nodes)
                    {

                        string scid = node.Attributes["PrimaryServiceConfigId"].Value;

                        sw.WriteLine(scid);
                        LabelSavedSCID.Text = scid;
                        Properties.Settings.Default.SCIDValue = scid;
                    }

                }

            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void XboxSettings_Load(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void ButtonBrowseAppxManifestFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Locate AppxManifest.xml file of your Xbox Project",
                    InitialDirectory = Application.StartupPath + @"\AppxManifest",
                    Filter = "All files (*.xml*)|*.xml*",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBoxAppxManifestFile.Text = openFileDialog.FileName;
                    GetSCID();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace.ToString());
            }
        }

        private void ButtonBrowseExportedSavesPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Choose where to save the save file!"
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxExportedSavesPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }


    }
}
