using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula5_exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPossoVotar_Click(object sender, EventArgs e)
        {
            int ano = Convert.ToInt32(txtAnoNascimento.Text);

            int resultado;

            resultado = 2022 - ano;

            if (resultado >= 16)
            {
                txtResultado.Text = resultado.ToString();
                MessageBox.Show("Pode votar!");
               
            }else
            {
                txtResultado.Text = resultado.ToString();
                MessageBox.Show("Não poderá votar!!");
            }
        }
    }
}
