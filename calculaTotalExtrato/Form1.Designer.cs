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
            this.btnUpload.Location = new System.Drawing.Point(50, 50);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(300, 50);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Adicione seu extrato aqui";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpload.Padding = new Padding(10);
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
            this.lblTotal.Location = new System.Drawing.Point(50, 120);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(300, 23);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblMediaMensal
            // 
            this.lblMediaMensal.Location = new System.Drawing.Point(50, 150);
            this.lblMediaMensal.Name = "lblMediaMensal";
            this.lblMediaMensal.Size = new System.Drawing.Size(300, 23);
            this.lblMediaMensal.TabIndex = 2;
            this.lblMediaMensal.Text = "Média Mensal:";
            this.lblMediaMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(50, 180);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(300, 50);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Baixar Excel";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDownload.Padding = new Padding(10);
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250); // Definindo tamanho fixo da janela
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMediaMensal);
            this.Controls.Add(this.btnDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Formulário com tamanho fixo
            this.MaximizeBox = false; // Desabilitar botão de maximizar
            this.MinimizeBox = false; // Desabilitar botão de minimizar
            this.Name = "Form1";
            this.Text = "Calcular Totais Extrato";
            this.ResumeLayout(false);
        }
    }
}
