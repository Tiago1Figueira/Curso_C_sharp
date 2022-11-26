using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Estudo_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salarioFixo = Convert.ToDouble(txtSalarioFixo.Text);
            double qtdCarrosVendidos = Convert.ToDouble(txtQtdCarroVendido.Text);
            double valorTotalVendas = Convert.ToDouble(txtValorTotalVendas.Text);
            double comissaoFixa = Convert.ToDouble(txtComissaoFixa.Text);

            double salarioFinal = salarioFixo + comissaoFixa * qtdCarrosVendidos + 0.05 * valorTotalVendas;

            txtSalarioFinal.Text = salarioFinal.ToString("N2");
        }
    }
}
