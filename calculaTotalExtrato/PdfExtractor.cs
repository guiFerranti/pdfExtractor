using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class PdfExtractor
{
    public List<string[]> ExtractTableFromPdf(string pdfPath)
    {
        List<string[]> tableData = new List<string[]>();

        using (PdfReader reader = new(pdfPath))
        {
            using (PdfDocument pdfDocument = new(reader))
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
                        for (int i = 1; i <= 4; i++)
                        {
                            rowData[i - 1] = match.Groups[i].Value.Trim();
                        }
                        tableData.Add(rowData);
                    }
                }
            }
        }

        return tableData;
    }
}
