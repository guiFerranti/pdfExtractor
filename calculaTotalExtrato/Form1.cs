using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace calculaTotalExtrato
{
    public partial class Form1 : Form
    {
        private PdfExtractor pdfExtractor;
        private ExcelExporter excelExporter;

        public Form1()
        {
            InitializeComponent();
            pdfExtractor = new PdfExtractor();
            excelExporter = new ExcelExporter();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Arquivos PDF|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pdfPath = openFileDialog.FileName;

                // Extrair dados do PDF
                List<string[]> tableData = pdfExtractor.ExtractTableFromPdf(pdfPath);

                // Exportar para Excel
                string excelFilePath = Path.Combine(Path.GetDirectoryName(pdfPath), "Extrato.xlsx");
                excelExporter.ExportToExcel(tableData, excelFilePath);

                MessageBox.Show("Tabela extraída e exportada para Excel com sucesso!");
            }
        }
    }
}
