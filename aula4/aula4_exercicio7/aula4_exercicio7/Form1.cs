using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4_exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParImparPositivoNegativo_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtNumero.Text);

            if (numero > 0 && numero % 2 == 0)
            {
                MessageBox.Show("O número é positivo e par!");
            }
            else if (numero > 0 && numero % 2 == 1)
            {
                MessageBox.Show("O número é positivo e ímpar!");
            }
            else if (numero < 0 && numero % 2 == 0)
            {
                MessageBox.Show("O número é negativo e par!");
            }
            else if (numero < 0 && numero % 2 != 0)
            {
                MessageBox.Show("O número é negativo e ímpar!");
            }
            else if(numero == 0)
                MessageBox.Show("O número é nulo!");

        }
    }
}
