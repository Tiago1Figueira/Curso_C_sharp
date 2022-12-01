using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula09_ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numcarros = Convert.ToInt32(txtCarrosVendidos.Text);
            double totalvendas = Convert.ToDouble(txtTotalVendas.Text);
            double salfixo = Convert.ToDouble(txtSalarioFixo.Text);
            double comissaofixa = Convert.ToDouble(txtComissaoFixa.Text);

            double salfinal;

            salfinal = salfixo + (totalvendas * 0.05) + (numcarros * comissaofixa);

            txtSalarioFinal.Text = salfinal + "reais".ToString();








        }
    }
}
