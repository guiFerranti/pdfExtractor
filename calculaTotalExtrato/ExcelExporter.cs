using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

public class ExcelExporter
{
    public void ExportToExcel(List<string[]> data, string excelFilePath)
    {
        using (ExcelPackage excelPackage = new())
        {
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Extrato");

            worksheet.Cells[1, 1].Value = "Data";
            worksheet.Cells[1, 2].Value = "Lançamentos";
            worksheet.Cells[1, 3].Value = "Valor (R$)";
            worksheet.Cells[1, 4].Value = "Saldo (R$)";

            int row = 2;
            foreach (var rowValues in data)
            {
                for (int i = 0; i < rowValues.Length; i++)
                {
                    worksheet.Cells[row, i + 1].Value = rowValues[i];
                }
                row++;
            }

            FileInfo excelFile = new(excelFilePath);
            excelPackage.SaveAs(excelFile);
        }
    }
}
