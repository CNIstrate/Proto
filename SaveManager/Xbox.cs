using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SaveManager
{

    public partial class Xbox : Form
    { 
        public string scidpath;
        public string exportLocation;
        public string importLocation;
        string pathToIPFile = @"C:\SaveManager\locations\xbconsoleip.txt";
        public bool needIP;
        public Xbox()
        {
            InitializeComponent();
            importButton.Enabled = false;
            exportButton.Enabled = false;
            deleteButton.Enabled = false;
            
            if (File.Exists(pathToIPFile))
            {
                string[] lines = File.ReadAllLines(pathToIPFile);
                foreach (string line in lines)
                {
                    needIP = false;
                    consoleIP.Text = line;
                }

            }
            else
            {
                needIP = true;
                consoleIP.Text = "Enter console IP address";
                StatusLabel.Text = "Not connected";
            }

        }
      
        private async void ExportButton(object sender, EventArgs e)
        {
            bool matchSCID = Regex.IsMatch(scidbox.Text, @"\d{8,9}\-?\d{3,4}\-?\d{3,4}\-?\d{4,4}\-?");
            if (!matchSCID)
            {
                MessageBox.Show("Enter the correct SCID of the Title!","Wrong SCID");            
            }
            else
            {
                Process proc = null;
                try
                {
                    exportTextBox.Text = "Working...";
                    string batDir = string.Format(@"C:\SaveManager\scripts\");
                    
                    var path = @"C:\SaveManager\locations\xbExportLocation.txt";
                    string text = exportLocation;
                    File.WriteAllText(path, text);
                    await Task.Delay(1000);
                    proc = new Process();
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.StartInfo.WorkingDirectory = batDir;
                    proc.StartInfo.FileName = "xbexport.bat";   
                    proc.Start();
                    proc.WaitForExit();
                    
                    await Task.Delay(2000);
                    exportTextBox.Text = ("Done!");
                    await Task.Delay(2000);
                    exportTextBox.Text = ("- - -");

                }
                catch (Exception ex)
                {
                    Console.Write(ex.StackTrace.ToString());
                }
            }
        }

        private async void ImportButton(object sender, EventArgs e)
        {
            bool matchSCID = Regex.IsMatch(scidbox.Text, @"\d{8,9}\-?\d{3,4}\-?\d{3,4}\-?\d{4,4}\-?");
            if (!matchSCID)
            {
                MessageBox.Show("Enter the correct SCID of the Title!", "Wrong SCID!!!");
                
            }
            else
            {

                Process proc = null;
                try
                {
                    importTextBox.Text = "Working...";
                    string batDir = string.Format(@"C:\SaveManager\scripts\");

                    importLocation = importBrowse.Text;
                    var path = @"C:\SaveManager\locations\xbImportLocation.txt";
                    string text = importLocation;
                    File.WriteAllText(path, text);
                    await Task.Delay(1000);

                    proc = new Process();
                    proc.StartInfo.WorkingDirectory = batDir;
                    proc.StartInfo.FileName = "xbimport.bat";
                    proc.StartInfo.CreateNoWindow = false;
                    proc.Start();
                    proc.WaitForExit();
                    await Task.Delay(2000);
                    importTextBox.Text = ("Done!");
                    await Task.Delay(2000);
                    importTextBox.Text = ("- - -");

                }
                catch (Exception ex)
                {
                    Console.Write(ex.StackTrace.ToString());
                }
            }
        }

        private async void DeleteButton(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the save file?\nYou cannot revert this action!", "Confirm deletion", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    Process proc = null;
                    try
                    {
                        deleteTextBox.Text = "Working...";
                        string batDir = string.Format(@"C:\SaveManager\scripts\");
                        proc = new Process();
                        proc.StartInfo.WorkingDirectory = batDir;
                        proc.StartInfo.FileName = "xbdeletesave.bat";
                        proc.StartInfo.CreateNoWindow = false;
                        proc.Start();
                        proc.WaitForExit();
                        await Task.Delay(2000);
                        deleteTextBox.Text = ("Done!");
                        await Task.Delay(2000);
                        deleteTextBox.Text = ("- - -");

                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.StackTrace.ToString());
                    }
                    break;
                case DialogResult.No:
                    break;
            }

        }

        private void GetSCID(object sender, EventArgs e)
        {

            string fileName = scidpath+"\\scid.txt";
            try
            {

                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(dial.Text);

                    XmlNodeList nodes = doc.GetElementsByTagName("mx:XboxLive");

                    //loop through each node in the XML
                    foreach (XmlNode node in nodes)
                    {

                        string scid = node.Attributes["PrimaryServiceConfigId"].Value;

                        sw.WriteLine(scid);
                        scidbox.Text = scid;
                    }

                    
                }
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void BrowseAppxFile(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fdlgs = new OpenFileDialog();
                fdlgs.Title = "Locate AppxManifest.xml file of your Xbox Project";
                fdlgs.InitialDirectory = @"C:\SaveManager\AppxManifest";
                fdlgs.Filter = "All files (*.xml*)|*.xml*";
                fdlgs.FilterIndex = 2;
                fdlgs.RestoreDirectory = true;
                if (fdlgs.ShowDialog() == DialogResult.OK)
                {
                    dial.Text = fdlgs.FileName;
                }

                FolderBrowserDialog foldlg = new FolderBrowserDialog();

                foldlg.SelectedPath = Path.GetDirectoryName(fdlgs.FileName);
                scidpath = foldlg.SelectedPath;


            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace.ToString());
            }
        }

        private void BackButton(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void SCIDbox_TextChanged(object sender, EventArgs e)
        {
            if(scidbox.Text != "-")
            {
                importButton.Enabled = true;
                exportButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void ExportBrowseButton(object sender, EventArgs e)
        {
            FolderBrowserDialog fdlg = new FolderBrowserDialog();
            fdlg.Description = "Choose where to save the save file!";

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                exportBrowse.Text = fdlg.SelectedPath;
                exportLocation = fdlg.SelectedPath;

            }
        }

        private void ImportBrowseButton(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Locate save file of your project";
            fdlg.InitialDirectory = @"c:\savemanager\saves";
            fdlg.Filter = "All files (*.xml*)|*.xml*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                importBrowse.Text = fdlg.FileName;
            }
            FolderBrowserDialog impfold = new FolderBrowserDialog();
            impfold.SelectedPath = importBrowse.Text;
            
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            string ipaddress;

            if (Regex.IsMatch(consoleIP.Text, @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b"))
            {
                if (needIP == false)
                {
                    //connect
                    File.Delete(pathToIPFile);
                    Process proc = null;
                    try
                    {
                        ipaddress = consoleIP.Text;
                        File.WriteAllText(pathToIPFile, ipaddress);
                        await Task.Delay(1000);
                        string batDir = string.Format(@"C:\SaveManager\scripts\");
                        proc = new Process();
                        proc.StartInfo.WorkingDirectory = batDir;
                        proc.StartInfo.FileName = "xbconnect.bat";
                        proc.StartInfo.CreateNoWindow = false;
                        proc.Start();
                        proc.WaitForExit();
                        await Task.Delay(1500);
                        StatusLabel.Text = "Connected";

                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.StackTrace.ToString());
                    }

                }
                else
                {
                    //create file and then connect
                    var path = @"C:\SaveManager\locations\xbconsoleip.txt";
                    ipaddress = consoleIP.Text;
                    File.WriteAllText(path, ipaddress);
                    await Task.Delay(1000);
                    //connect
                    Process proc = null;
                    try
                    {
                        string batDir = string.Format(@"C:\SaveManager\scripts\");
                        proc = new Process();
                        proc.StartInfo.WorkingDirectory = batDir;
                        proc.StartInfo.FileName = "xbconnect.bat";
                        proc.StartInfo.CreateNoWindow = false;
                        proc.Start();
                        proc.WaitForExit();
                        await Task.Delay(1500);
                        StatusLabel.Text = "Connected";
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.StackTrace.ToString());
                    }
                }
            }
            else
            {
                consoleIP.Text = "Wrong IP address";
            }
        }
    }
    
}
