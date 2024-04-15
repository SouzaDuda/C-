namespace exercicio1
{
    partial class frmcarro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblvalordefabrica = new System.Windows.Forms.Label();
            this.lblimposto = new System.Windows.Forms.Label();
            this.lbllucro = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtfabrica = new System.Windows.Forms.TextBox();
            this.txtimposto = new System.Windows.Forms.TextBox();
            this.txtlucro = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(329, 27);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(101, 13);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Cálculo com o carro";
            // 
            // lblvalordefabrica
            // 
            this.lblvalordefabrica.AutoSize = true;
            this.lblvalordefabrica.Location = new System.Drawing.Point(45, 108);
            this.lblvalordefabrica.Name = "lblvalordefabrica";
            this.lblvalordefabrica.Size = new System.Drawing.Size(81, 13);
            this.lblvalordefabrica.TabIndex = 1;
            this.lblvalordefabrica.Text = "Valor de fábrica";
            // 
            // lblimposto
            // 
            this.lblimposto.AutoSize = true;
            this.lblimposto.Location = new System.Drawing.Point(45, 168);
            this.lblimposto.Name = "lblimposto";
            this.lblimposto.Size = new System.Drawing.Size(84, 13);
            this.lblimposto.TabIndex = 2;
            this.lblimposto.Text = "Valor c/ imposto";
            // 
            // lbllucro
            // 
            this.lbllucro.AutoSize = true;
            this.lbllucro.Location = new System.Drawing.Point(45, 228);
            this.lbllucro.Name = "lbllucro";
            this.lbllucro.Size = new System.Drawing.Size(72, 13);
            this.lbllucro.TabIndex = 3;
            this.lbllucro.Text = "Valor do lucro";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(49, 285);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(54, 13);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "Valor total";
            // 
            // txtfabrica
            // 
            this.txtfabrica.Location = new System.Drawing.Point(172, 101);
            this.txtfabrica.Name = "txtfabrica";
            this.txtfabrica.Size = new System.Drawing.Size(152, 20);
            this.txtfabrica.TabIndex = 5;
            // 
            // txtimposto
            // 
            this.txtimposto.Location = new System.Drawing.Point(172, 161);
            this.txtimposto.Name = "txtimposto";
            this.txtimposto.Size = new System.Drawing.Size(152, 20);
            this.txtimposto.TabIndex = 6;
            // 
            // txtlucro
            // 
            this.txtlucro.Location = new System.Drawing.Point(172, 221);
            this.txtlucro.Name = "txtlucro";
            this.txtlucro.Size = new System.Drawing.Size(152, 20);
            this.txtlucro.TabIndex = 7;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(172, 278);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(152, 20);
            this.txttotal.TabIndex = 8;
            // 
            // frmcarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtlucro);
            this.Controls.Add(this.txtimposto);
            this.Controls.Add(this.txtfabrica);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbllucro);
            this.Controls.Add(this.lblimposto);
            this.Controls.Add(this.lblvalordefabrica);
            this.Controls.Add(this.lbltitulo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "frmcarro";
            this.Text = " Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblvalordefabrica;
        private System.Windows.Forms.Label lblimposto;
        private System.Windows.Forms.Label lbllucro;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtfabrica;
        private System.Windows.Forms.TextBox txtimposto;
        private System.Windows.Forms.TextBox txtlucro;
        private System.Windows.Forms.TextBox txttotal;
    }
}

