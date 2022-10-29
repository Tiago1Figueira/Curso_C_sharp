using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula3_exercicio1_soma_numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            double.TryParse(txtNumero1.Text, out numero1);
            double.TryParse(txtNumero2.Text, out numero2);

            resultado = numero1 + numero2;

            txtResultado.Text = resultado.ToString();

        }
    }
}
