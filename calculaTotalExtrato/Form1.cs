using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace calculaTotalExtrato
{
    public partial class Form1 : Form
    {
        private List<string[]> tableData = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pdfPath = openFileDialog.FileName;

                PdfExtractor extractor = new PdfExtractor();
                tableData = extractor.ExtractTableFromPdf(pdfPath);

                // Calcular total dos valores positivos
                decimal totalValoresPositivos = 0;
                foreach (var row in tableData)
                {
                    if (!string.IsNullOrEmpty(row[2]) && decimal.TryParse(row[2].Replace(".", "").Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valor))
                    {
                        if (valor > 0)
                        {
                            totalValoresPositivos += valor;
                        }
                    }
                }

                // Calcular média mensal
                decimal mediaMensal = (totalValoresPositivos * 0.7m) / 6;

                // Exibir resultados
                CultureInfo culturaBrasileira = new CultureInfo("pt-BR");
                lblTotal.Text = $"Total: {totalValoresPositivos.ToString("C", culturaBrasileira)}";
                lblMediaMensal.Text = $"Média Mensal: {mediaMensal.ToString("C", culturaBrasileira)}";
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (tableData != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    ExcelExporter exporter = new ExcelExporter();
                    exporter.ExportToExcel(tableData, savePath);
                    MessageBox.Show("Arquivo Excel salvo com sucesso em " + savePath);
                }
            }
            else
            {
                MessageBox.Show("Por favor, carregue um extrato primeiro.");
            }
        }
    }
}
