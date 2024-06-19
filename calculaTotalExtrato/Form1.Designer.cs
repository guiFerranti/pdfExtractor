namespace calculaTotalExtrato
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnUpload;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog; // Novo SaveFileDialog
        private Label lblTotal;
        private Label lblMediaMensal;
        private Button btnDownload;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog(); // Inicialize o SaveFileDialog
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMediaMensal = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(10, 10);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(200, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Adicione seu extrato aqui";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Arquivos PDF|*.pdf"; // Filtro para aceitar apenas PDFs
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Arquivos Excel|*.xlsx"; // Filtro para salvar como Excel
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(10, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 23);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // lblMediaMensal
            // 
            this.lblMediaMensal.Location = new System.Drawing.Point(10, 70);
            this.lblMediaMensal.Name = "lblMediaMensal";
            this.lblMediaMensal.Size = new System.Drawing.Size(200, 23);
            this.lblMediaMensal.TabIndex = 2;
            this.lblMediaMensal.Text = "Média Mensal:";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(10, 100);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(200, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Baixar Excel";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMediaMensal);
            this.Controls.Add(this.btnDownload);
            this.Name = "Form1";
            this.Text = "Calcula Total Extrato";
            this.ResumeLayout(false);
        }
    }
}
