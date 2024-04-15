namespace Exemplo1
{
    partial class frmexemplo
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
            this.lblnum = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblsoma = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(14, 30);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(89, 13);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Digite um número";
            this.lblnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(14, 83);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(99, 13);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Digite outro número";
            // 
            // lblsoma
            // 
            this.lblsoma.AutoSize = true;
            this.lblsoma.Location = new System.Drawing.Point(14, 138);
            this.lblsoma.Name = "lblsoma";
            this.lblsoma.Size = new System.Drawing.Size(55, 13);
            this.lblsoma.TabIndex = 2;
            this.lblsoma.Text = "Resultado";
            this.lblsoma.Click += new System.EventHandler(this.lblsoma_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.ControlText;
            this.btncalcular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncalcular.Location = new System.Drawing.Point(17, 212);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(116, 37);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Black;
            this.btnlimpar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlimpar.Location = new System.Drawing.Point(155, 212);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(116, 37);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtnum.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnum.Location = new System.Drawing.Point(130, 30);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(141, 20);
            this.txtnum.TabIndex = 5;
            // 
            // txtnum2
            // 
            this.txtnum2.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtnum2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnum2.Location = new System.Drawing.Point(130, 83);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(141, 20);
            this.txtnum2.TabIndex = 6;
            this.txtnum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtresultado.Enabled = false;
            this.txtresultado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtresultado.Location = new System.Drawing.Point(130, 135);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(141, 20);
            this.txtresultado.TabIndex = 7;
            this.txtresultado.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsair.Location = new System.Drawing.Point(289, 212);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(116, 37);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmexemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblsoma);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "frmexemplo";
            this.Text = "Soma de dois números";
            this.Load += new System.EventHandler(this.frmexemplo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblsoma;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnsair;
    }
}

