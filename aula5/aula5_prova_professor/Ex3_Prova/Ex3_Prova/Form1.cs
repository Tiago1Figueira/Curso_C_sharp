using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txtTotal.Text);
            double brancos = Convert.ToDouble(txtBranco.Text);
            double nulos = Convert.ToDouble(txtNulos.Text);
            double validos = Convert.ToDouble(txtValidos.Text);

            double per_branco, per_nulo, per_valido;

            per_branco = brancos / total * 100;
            per_nulo = nulos / total * 100;
            per_valido = validos / total * 100;

            lblBranco.Text = per_branco + "%";
            lblNulos.Text = per_nulo + "%";
            lblValidos.Text = per_valido + "%";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblBranco.Text = "";
            lblNulos.Text = "";
            lblValidos.Text = "";
        }
    }
}
