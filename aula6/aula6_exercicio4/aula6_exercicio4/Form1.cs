using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6_exercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            double centimetros = Convert.ToDouble(txtCentimetros.Text);

            double metros, km;

            metros = centimetros / 100;
            km = centimetros / 10000;

            txtMetros.Text = metros + "metros".ToString();
            txtKm.Text = km + "quilômetros".ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCentimetros.Text = "";
            txtMetros.Text = "";
            txtKm.Text = "";

        }
    }
}
