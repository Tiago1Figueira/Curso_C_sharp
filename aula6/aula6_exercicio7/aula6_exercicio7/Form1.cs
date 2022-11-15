using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6_exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double nota4 = Convert.ToDouble(txtNota4.Text);

            double media;

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            txtResultado.Text = media.ToString();
            
            if (media <= 4)
            {
                MessageBox.Show("Aluno Reprovado!");
            }
            else if (media > 4 & media < 6)
            {
                MessageBox.Show("Aluno de Recuperação!");

            }
            else if (media >= 6 & media <= 10) 
            {
                MessageBox.Show("Aluno Aprovado!");
            }
            else
            {
                MessageBox.Show("Notas Inválidas!");
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtResultado.Text = "";
        }
    }
}
