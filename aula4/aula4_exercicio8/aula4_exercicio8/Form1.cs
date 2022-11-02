using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4_exercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

           if (numero1 == numero2)
            {
                MessageBox.Show("Números Iguais!");
            }
            else if (numero1 > numero2)
            {
                MessageBox.Show("O primeiro número é maior que o segundo!");
            }
           else if (numero1 < numero2)
            {
                MessageBox.Show("O segundo número é maior que o primeiro!");
            }


        }
    }
}
