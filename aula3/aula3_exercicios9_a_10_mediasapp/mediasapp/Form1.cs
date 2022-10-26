using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediasapp
{
    public partial class txtCalculoMedias : Form
    {
        public txtCalculoMedias()
        {
            InitializeComponent();
        }

        private void btnMediaAritmetica_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, resultado;

            n1 = Convert.ToDouble(txtnota1.Text);
            n2 = Convert.ToDouble(txtnota2.Text);
            n3 = Convert.ToDouble(txtnota3.Text);
            n4 = Convert.ToDouble(txtnota4.Text);

            resultado = (n1 + n2 + n3 + n4) / 4;
            txtResultado.Text = resultado.ToString();

        }

        private void btnMediaPonderada_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, resultado;

            n1 = Convert.ToDouble(txtnota1.Text);
            n2 = Convert.ToDouble(txtnota2.Text);
            n3 = Convert.ToDouble(txtnota3.Text);
            n4 = Convert.ToDouble(txtnota4.Text);

            resultado = ((n1 + n2 + n3) / 3) * 0.3 + n4 * 0.7;
            txtResultado.Text = resultado.ToString();
        }
    }
}
