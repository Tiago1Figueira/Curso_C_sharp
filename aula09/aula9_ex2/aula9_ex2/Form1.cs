using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula9_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }

        private void cbEmbalagemEspecial_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valorProduto = Convert.ToDouble(txtValorProduto.Text);
            double quantidade = Convert.ToDouble(txtQuantidadeVendida.Text);
            double valorLiquido, valorBruto;
            double acrescimo, valorFinal, percentualEmbalagem;
            double animal, vegetal, outros, embalagem;

            animal = 0.15;
            vegetal = 0.10;
            outros = 0.043;
            embalagem = 0.077;
            acrescimo = 0;
            percentualEmbalagem = 0;
            valorFinal = 0;

            valorBruto = valorProduto * quantidade;
            switch (cbOrigem.SelectedIndex)
            {
                case 0:
                    acrescimo = valorBruto * animal;
                    break;
                case 1:
                    acrescimo = valorBruto * vegetal;
                    break;
                case 2:
                    acrescimo = valorBruto * outros;
                    break;
            }
            valorLiquido = valorBruto + acrescimo;

            switch (cbEmbalagemEspecial.SelectedIndex)
            {
                case 0:
                    percentualEmbalagem = valorLiquido * (embalagem * quantidade);
                    valorFinal = valorLiquido + percentualEmbalagem;
                    break;

                case 1:
                    percentualEmbalagem = 0;
                    valorFinal = valorLiquido + percentualEmbalagem;
                    break;

                    if (cbOrigem.SelectedIndex < 0)

                    {
                        MessageBox.Show("Você deve escolher a origem do produto primeiramente!");
                        cbEmbalagemEspecial.SelectedItem = -1;
                    }

            }

            txtValorLiquido.Text = valorLiquido + "reais".ToString();
            txtAcrescimo.Text = acrescimo + "reais".ToString();
            txtValorBruto.Text = valorBruto + "reais".ToString();
            txtValorFinal.Text = valorFinal + "reais".ToString();

        }
    }
}
