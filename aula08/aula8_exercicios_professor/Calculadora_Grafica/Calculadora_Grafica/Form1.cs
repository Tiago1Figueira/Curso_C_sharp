using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);

            if (rbSoma.Checked)
            {
                txtResultado.Text = (valor1 + valor2).ToString();
            }

            if (rbSubtracao.Checked)
            {
                txtResultado.Text = (valor1 - valor2).ToString();
            }

            if (rbMultiplicacao.Checked)
            {
                txtResultado.Text = (valor1 * valor2).ToString();
            }

            if (rbDivisao.Checked)
            {
                txtResultado.Text = (valor1 / valor2).ToString();
            }

        }
    }
}
