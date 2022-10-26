using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valornumerico
{
    public partial class txtCalculoValoresNumericos : Form
    {
        public txtCalculoValoresNumericos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bntProcessar_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtNumero.Text);
            double anterior, posterior, dobro, triplo, por25, por50, por100, por150;

            anterior = numero - 1;
            posterior = numero + 1;
            dobro = numero * 2;
            triplo = numero * 3;
            por25 = numero * 0.25;
            por50 = numero * 0.5;
            por100 = numero * 1;
            por150 = numero * 1.5;

            txtAnterior.Text = anterior.ToString();
            txtPosterior.Text = posterior.ToString();
            txtDobro.Text = dobro.ToString();
            txtTriplo.Text = triplo.ToString();
            txt25.Text = por25.ToString();
            txt50.Text = por50.ToString();
            txt100.Text = por100.ToString();
            txt150.Text = por150.ToString();




        }
    }
}
