using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula5_exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            double populacao = Convert.ToDouble(txtPopulacao.Text);
            double validos = Convert.ToDouble(txtValidos.Text);
            double nulos = Convert.ToDouble(txtNulos.Text);
            double brancos = Convert.ToDouble(txtBrancos.Text);

            validos = (validos / populacao) * 100;
            nulos = (nulos / populacao) * 100;
            brancos = (brancos / populacao) * 100;

            txtValidos1.Text = validos.ToString();
            txtNulos1.Text = nulos.ToString();
            txtBrancos1.Text = brancos.ToStri50ng();








        }
    }
}
