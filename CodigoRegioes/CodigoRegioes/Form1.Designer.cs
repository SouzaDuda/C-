namespace CodigoRegioes
{
    partial class frmcodigo
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
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtcomdesconto = new System.Windows.Forms.TextBox();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(60, 65);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(186, 20);
            this.txtpreco.TabIndex = 0;
            this.txtpreco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcomdesconto
            // 
            this.txtcomdesconto.Location = new System.Drawing.Point(60, 251);
            this.txtcomdesconto.Name = "txtcomdesconto";
            this.txtcomdesconto.ReadOnly = true;
            this.txtcomdesconto.Size = new System.Drawing.Size(186, 20);
            this.txtcomdesconto.TabIndex = 1;
            this.txtcomdesconto.Text = "(";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(57, 36);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(35, 13);
            this.lblpreco.TabIndex = 2;
            this.lblpreco.Text = "Preço";
            this.lblpreco.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(57, 225);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(105, 13);
            this.lblvalor.TabIndex = 3;
            this.lblvalor.Text = "Preço com desconto";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(60, 125);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(186, 20);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "Norte - 1\r\nSul - 2\r\nSudeste - 3\r\nNordeste - 4\r\nCentro-Oeste - 5\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(544, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Regiões";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(57, 100);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 7;
            this.lblcodigo.Text = "Código";
            this.lblcodigo.Click += new System.EventHandler(this.label3_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(60, 354);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(111, 52);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(281, 354);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(115, 52);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(607, 421);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 10;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Location = new System.Drawing.Point(57, 167);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(53, 13);
            this.lbldesconto.TabIndex = 11;
            this.lbldesconto.Text = "Desconto";
            // 
            // txtdesconto
            // 
            this.txtdesconto.Location = new System.Drawing.Point(60, 193);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(186, 20);
            this.txtdesconto.TabIndex = 12;
            // 
            // frmcodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 523);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.lbldesconto);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.txtcomdesconto);
            this.Controls.Add(this.txtpreco);
            this.Name = "frmcodigo";
            this.Load += new System.EventHandler(this.frmcodigo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtcomdesconto;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.TextBox txtdesconto;
    }
}

