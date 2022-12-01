using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4.exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPositivoNegativoNulo_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtNumero.Text);

            if (numero < 0)
            {
                MessageBox.Show("O número é negativo!");
            }
            else if (numero > 0)
            {
                MessageBox.Show("O número é positivo!");
            }
            else if (numero == 0)
            {
                MessageBox.Show("O número é nulo!");
            }
        }
    }
}
