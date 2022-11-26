using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Estudo_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCustoFabrica_TextChanged(object sender, EventArgs e)
        {
            if (txtCustoFabrica.Text.Length != 0)
            {
                double custoFabrica = Convert.ToDouble(txtCustoFabrica.Text);
                double imposto = custoFabrica * 0.45;
                double distribuidor = custoFabrica * 0.28;
                double custoFinal = custoFabrica + imposto + distribuidor;
                txtImposto.Text = imposto.ToString("N2");
                txtDistribuidor.Text = distribuidor.ToString("N2");
                txtCustoFinal.Text = custoFinal.ToString("N2");
            } else
            {
                txtImposto.Text = "";
                txtDistribuidor.Text = "";
                txtCustoFinal.Text = "";
            }
        }
    }
}
