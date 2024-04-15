using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo1
{
    public partial class frmexemplo : Form
    {
        public frmexemplo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsoma_Click(object sender, EventArgs e)
        {

        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            num1 = Convert.ToDouble(txtnum.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            result = num1 + num2;

            txtresultado.Text = result.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtnum2.Clear();
            txtresultado.Clear();
            txtnum.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmexemplo_Load(object sender, EventArgs e)
        {

        }
    }
}
