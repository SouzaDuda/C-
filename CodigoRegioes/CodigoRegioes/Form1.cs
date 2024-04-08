using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoRegioes
{
    public partial class frmcodigo : Form
    {
        public frmcodigo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double preco, codigo, result;
            
            preco = Convert.ToDouble(txtpreco.Text);
            codigo = Convert.ToDouble(txtcodigo.Text);

            if (codigo == 1)
            {
                result = preco - (5 / 100);

                txtcomdesconto.Text = result.ToString();
            }
            else if (codigo == 2)
            {
                result = preco - (15 / 100);
                txtcomdesconto.Text = result.ToString();

            }
            else if (codigo == 3)
            {
                result = preco - (7 / 100);
                txtcomdesconto.Text = result.ToString();
            }
            else if (codigo == 4)
            {
                result = preco - (12 / 100);
                txtcomdesconto.Text = result.ToString();

            }
            else if (codigo == 5)
            {
                result = preco - (20 / 100);
                txtcomdesconto.Text = result.ToString();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmcodigo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
