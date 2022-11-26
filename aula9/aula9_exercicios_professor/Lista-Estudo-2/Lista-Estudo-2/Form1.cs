using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Estudo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularCompra_Click(object sender, EventArgs e)
        {
            double valorProduto = Convert.ToDouble(txtValorProduto.Text);
            double quantidade = Convert.ToDouble(txtQuantidade.Text);

            double valorLiquido = valorProduto * quantidade;
            double acrescimos = 0.0;

            switch (cbOrigem.SelectedItem.ToString())
            {
                case "Animal":
                    acrescimos = valorLiquido * 0.15;
                    break;
                case "Vegetal":
                    acrescimos = valorLiquido * 0.10;
                    break;
                case "Outros":
                    acrescimos = valorLiquido * 0.043;
                    break;
            }

            double valorBruto = valorLiquido + acrescimos;

            if (cbEmbalagem.SelectedItem.Equals("Sim"))
            {
                double percentualEmbalagem = valorBruto * 0.077;
                valorBruto += percentualEmbalagem;
                acrescimos += percentualEmbalagem;
            }

            txtValorLiquido.Text = valorLiquido.ToString("N2");
            txtValorAcrescimos.Text = acrescimos.ToString("N2");
            txtValorBruto.Text = valorBruto.ToString("N2");
        }
    }
}
