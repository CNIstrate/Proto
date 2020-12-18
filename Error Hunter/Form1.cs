using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Error_Hunter
{

    public partial class windowTitle : Form
    {

        private string location;
        private string fileLocated;
        private string user;

        public windowTitle()
        {
            InitializeComponent();
            user = Environment.UserName;
            location = String.Format(@"C:\Users\{0}\Desktop\", user);

        }

        private async void ErrorExport_Click(object sender, EventArgs e)
        {

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select your log file";
            fdlg.InitialDirectory = location;
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fileLocated = fdlg.FileName;
            }
            else { return; }


            statusLabel.Text = "Busy... Please Wait";
            string[] lines = File.ReadAllLines(fileLocated);

            IEnumerable<string> selectLines = lines.Where(line => line.Contains(": Error:"));
            List<String> lista = new List<String>();

            foreach (var item in selectLines)
            {
                lista.Add(item);
            }

            using (var workBook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workBook.Worksheets.Add("Error list");
                for(int i = 1; i < lista.Count; i++)
                { 
                    worksheet.Cell("A"+i).Value = lista[i-1];
                
                }
                workBook.SaveAs(location + "Error Report.xlsx");
            }
   
            await Task.Delay(1000);
            statusLabel.Text = "Done!";
            await Task.Delay(1000);
            statusLabel.Text = "Idle";
        }

        private async void WarningExport_Click(object sender, EventArgs e)
        {

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select your log file";
            fdlg.InitialDirectory = location;
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fileLocated = fdlg.FileName;
            }
            else
            {
                return;
            }
            await Task.Delay(50);
            statusLabel.Text = "Busy... Please Wait";
            await Task.Delay(50);
            string[] lines = File.ReadAllLines(fileLocated);

            IEnumerable<string> selectLines = lines.Where(line => line.Contains("Warning:"));
            List<String> lista = new List<String>();

            foreach (var item in selectLines)
            {
                lista.Add(item.Substring(30));
            }

            using (var workBook = new ClosedXML.Excel.XLWorkbook())
            {
                List<string> linieFinal = new List<String>();
                List<string> countFinal = new List<String>();
                var worksheet = workBook.Worksheets.Add("Warning list");

                var q = from x in lista
                        group x by x into g
                        let count = g.Count()
                        orderby count descending
                        select new { Value = g.Key, Count = count };
                foreach(var x in q)
                {
                    linieFinal.Add(x.Value);
                    countFinal.Add(x.Count.ToString());
                }

                for (int i = 2; i < linieFinal.Count; i++)
                {
                    for (int j = 2; j < countFinal.Count; j++)
                    {
                        worksheet.Cell("A" + i).Value = countFinal[i-1];
                        worksheet.Cell("B" + j).Value = linieFinal[j-1];
                    }
                }

                worksheet.Cell("A1").Value = "Count";
                worksheet.Cell("A1").Style.Font.SetBold().Font.FontSize = 16;
                worksheet.Cell("B1").Value = "Warnings";
                worksheet.Cell("B1").Style.Alignment.SetHorizontal(ClosedXML.Excel.XLAlignmentHorizontalValues.Center);
                worksheet.Column(1).Style.Alignment.SetHorizontal(ClosedXML.Excel.XLAlignmentHorizontalValues.Center);

                var range = worksheet.Range("B1:Z1");
                int n = 10000;
                for (int i = 2; i< n; i++)
                {
                    var mergeLinesRange = worksheet.Range("B"+i+":Z"+i);
                    mergeLinesRange.Merge();
                }
                worksheet.Columns("AA:XFD").Hide();
                range.Merge().Style.Font.SetBold().Font.FontSize = 16;
                workBook.SaveAs(location + "Warning Report.xlsx");
            }

            await Task.Delay(1000);
            statusLabel.Text = "Done!";
            await Task.Delay(1000);
            statusLabel.Text = "Idle";
        }
    }
}
