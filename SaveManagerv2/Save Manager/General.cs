using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Manager
{
    class General
    {
        public static string versionNumber = "0.1";
        public static string installationPath = "0";

        public static string switchExportPath = "0";

        public static string xboxIP = "0";
        public static string SCID = "0";
        public static string appxManifestPath = "0";
        public static string xboxExportPath = "0";

        public static void GetInstallationPath()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Save Manager\Settings"))
                installationPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Save Manager";
            else
                installationPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Save Manager";
        }

        public static void SaveSettings()
        {
            File.WriteAllText(installationPath + @"\Settings\UserSettings", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Save Manager\Switch" + Environment.NewLine);

            File.AppendAllText(installationPath + @"\Settings\UserSettings", "0" + Environment.NewLine);
            File.AppendAllText(installationPath + @"\Settings\UserSettings", "0" + Environment.NewLine);
            File.AppendAllText(installationPath + @"\Settings\UserSettings", "0" + Environment.NewLine);
            File.AppendAllText(installationPath + @"\Settings\UserSettings", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Save Manager\Xbox One");
        }
    }
}
