namespace calculaTotalExtrato
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMediaMensal;

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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMediaMensal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpload do pdf
            // 
            this.btnUpload.Location = new System.Drawing.Point(10, 10);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(200, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Adicione seu extrato aqui";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblTotal total
            // 
            this.lblTotal.Location = new System.Drawing.Point(10, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 23);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // lblMediaMensal media mensal
            // 
            this.lblMediaMensal.Location = new System.Drawing.Point(10, 70);
            this.lblMediaMensal.Name = "lblMediaMensal";
            this.lblMediaMensal.Size = new System.Drawing.Size(200, 23);
            this.lblMediaMensal.TabIndex = 2;
            this.lblMediaMensal.Text = "Média Mensal:";
            // 
            // Form1 
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMediaMensal);
            this.Name = "Form1";
            this.Text = "Calcula Total Extrato";
            this.ResumeLayout(false);

        }
    }
}
