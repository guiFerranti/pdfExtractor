using OfficeOpenXml;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

public class ExcelExporter
{
    public void ExportToExcel(List<string[]> tableData, string filePath)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using (ExcelPackage excelPackage = new ExcelPackage())
        {
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Extrato");

            worksheet.Cells[1, 1].Value = "Data";
            worksheet.Cells[1, 2].Value = "Lançamentos";
            worksheet.Cells[1, 3].Value = "Valor (R$)";
            worksheet.Cells[1, 4].Value = "Saldo (R$)";

            for (int i = 0; i < tableData.Count; i++)
            {
                worksheet.Cells[i + 2, 1].Value = tableData[i][0];
                worksheet.Cells[i + 2, 2].Value = tableData[i][1];

                if (decimal.TryParse(tableData[i][2], NumberStyles.Number, new CultureInfo("pt-BR"), out decimal valor))
                {
                    worksheet.Cells[i + 2, 3].Value = valor;
                    worksheet.Cells[i + 2, 3].Style.Numberformat.Format = "#,##0.00";
                }
                else
                {
                    worksheet.Cells[i + 2, 3].Value = tableData[i][2];
                }

                if (decimal.TryParse(tableData[i][3], NumberStyles.Number, new CultureInfo("pt-BR"), out decimal saldo))
                {
                    worksheet.Cells[i + 2, 4].Value = saldo;
                    worksheet.Cells[i + 2, 4].Style.Numberformat.Format = "#,##0.00";
                }
                else
                {
                    worksheet.Cells[i + 2, 4].Value = tableData[i][3];
                }
            }

            worksheet.Column(1).AutoFit();
            worksheet.Column(2).AutoFit();
            worksheet.Column(3).AutoFit();
            worksheet.Column(4).AutoFit();

            FileInfo fileInfo = new FileInfo(filePath);
            excelPackage.SaveAs(fileInfo);
        }
    }
}
