using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6_exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);

            if (idade < 5)
            {
                txtNivel.Text = "Fora de classificação!".ToString();
            }
            else if (idade >= 5 && idade <= 7)
            {
                txtNivel.Text = "Infantil A!".ToString();
            }
            else if (idade >= 8 && idade <= 10)
            {
                txtNivel.Text = "Infantil B!".ToString();
            }
            else if (idade >= 11 && idade <= 13)
            {
                txtNivel.Text = "Juvenil A!".ToString();
            }
            else if (idade >= 14 && idade <= 17)
            {
                txtNivel.Text = "Juvenil B!".ToString();
            }
            else 
            {
                txtNivel.Text = "Sênior!".ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdade.Text = "";
            txtNivel.Text = "";

            
        }
    }
}
