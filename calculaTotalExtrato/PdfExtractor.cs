using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

public class PdfExtractor
{
    public List<string[]> ExtractTableFromPdf(string pdfPath)
    {
        List<string[]> tableData = new List<string[]>();

        using (PdfReader reader = new PdfReader(pdfPath))
        {
            using (PdfDocument pdfDocument = new PdfDocument(reader))
            {
                for (int pageNum = 1; pageNum <= pdfDocument.GetNumberOfPages(); pageNum++)
                {
                    PdfPage page = pdfDocument.GetPage(pageNum);
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string pageText = PdfTextExtractor.GetTextFromPage(page, strategy);

                    string pattern = @"(\d{2}/\d{2}/\d{4})\s+(.*?)\s+(-?\d{1,3}(?:\.\d{3})*,\d{2})";

                    MatchCollection matches = Regex.Matches(pageText, pattern);

                    foreach (Match match in matches)
                    {
                        string[] rowData = new string[4];

                        if (match.Groups[2].Value.StartsWith("SALDO TOTAL DISPONÃVEL DIA") || match.Groups[2].Value.StartsWith("SALDO ANTERIOR"))
                        {
                            rowData[0] = match.Groups[1].Value.Trim();
                            rowData[1] = match.Groups[2].Value.Trim();
                            rowData[2] = "";
                            rowData[3] = match.Groups[3].Value.Trim();
                        }
                        else
                        {
                            rowData[0] = match.Groups[1].Value.Trim();
                            rowData[1] = match.Groups[2].Value.Trim();
                            rowData[2] = match.Groups[3].Value.Trim();
                            rowData[3] = "";
                        }

                        tableData.Add(rowData);
                    }
                }
            }
        }

        return tableData;
    }

    public decimal CalcularTotalValoresPositivos(List<string[]> tableData)
    {
        decimal total = 0;

        foreach (var row in tableData)
        {
            if (!string.IsNullOrWhiteSpace(row[2]))
            {
                string valorFormatado = row[2].Replace(".", "").Replace(",", ".");
                decimal valor = Convert.ToDecimal(valorFormatado, CultureInfo.InvariantCulture);
                if (valor > 0)
                {
                    total += valor;
                }
            }
        }

        return total;
    }

    public decimal CalcularMediaMensal(decimal totalValoresPositivos)
    {
        return (totalValoresPositivos * 0.7m) / 6m;
    }
}
