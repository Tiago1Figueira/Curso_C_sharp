using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            int anoAtual = Convert.ToInt32(txtAnoAtual.Text);
            int anoNascimento = Convert.ToInt32(txtAnoNascimento.Text);

            int idade = anoAtual - anoNascimento;

            if (idade >= 16)
            {
                MessageBox.Show("Você pode votar!!!", "Resultado");
            } else
            {
                MessageBox.Show("Você NÃO pode votar!!!", "Resultado");
            }
        }
    }
}
