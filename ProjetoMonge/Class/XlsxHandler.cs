using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMonge.Class
{
    public class XlsxHandler
    {
        public void CreateXlsx(string filePath, List<string[]> nf)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {

                var worksheet = package.Workbook.Worksheets.Add("Planilha1");
                worksheet.Cells["A1"].Value = "Nota";
                worksheet.Cells["B1"].Value = "Valor";

                int i = 2;
                foreach (string[] item in nf)
                {

                    worksheet.Cells["A" + i.ToString()].Value = item[0];
                    worksheet.Cells["B" + i.ToString()].Value = item[1].Replace('.', ',');
                    i++;
                }
                FileInfo fi = new FileInfo(filePath);
                int j = 1;
                string filePathnew = filePath;
                while (fi.Exists)
                {
                    string extension = fi.Extension.ToString();
                    if (j > 1)
                    {
                        filePathnew = filePathnew.Replace($"({j - 1})", "");
                    }
                    filePathnew = filePathnew.Replace(extension, $"({j})") + extension;
                    fi = new FileInfo(filePathnew);
                    j++;
                }
                package.SaveAs(fi);
            }
        }
    }
}
