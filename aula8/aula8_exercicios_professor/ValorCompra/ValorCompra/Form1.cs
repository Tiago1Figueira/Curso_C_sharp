using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorCompra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valorCompra = Convert.ToDouble(txtValorCompra.Text);

            double valorFinal = 0;
            double valorParcela = 0;

            switch(cbFormaPagamento.SelectedIndex)
            {
                case 0:
                    valorFinal = valorCompra * 0.925;
                    break;
                case 1:
                    valorFinal = valorCompra * 1.05;
                    valorParcela = valorFinal / 2;
                    break;
                case 2:
                    valorFinal = valorCompra * 1.095;
                    valorParcela = valorFinal / 3;
                    break;
                case 3:
                    valorFinal = valorCompra * 1.125;
                    valorParcela = valorFinal / 4;
                    break;
            }

            txtValorFinal.Text = valorFinal.ToString("N2");
            txtValorParcela.Text = valorParcela.ToString("N2");
        }
    }
}
