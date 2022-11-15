using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6_exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCalcularMedia_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);

            double resultado;

            resultado = (nota1 + nota2) / 2;

            txtResultado.Text = resultado.ToString();
            if (resultado <= 5)
            {
                MessageBox.Show("Você foi reprovado!");
            }
            else
            {
                MessageBox.Show("Você foi aprovado!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtResultado.Text = "";
            
        }
    }
}
