using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4_exercicio10
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

            double mediaAritmetica;

            mediaAritmetica = (nota1 + nota2 + nota3 + nota4) / 4;

            txtResultado.Text = mediaAritmetica.ToString();
            
            if(mediaAritmetica >= 6) 
             {
                MessageBox.Show("Aluno aprovado!");
            }
            else
            {
                MessageBox.Show("Aluno reprovado!");
            }
        }
    }
}
