using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4_exercicio9
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
            double numero3 = Convert.ToDouble(txtNumero3.Text);

            double resultado; 
            

            if (numero1 > 0)
            {
                resultado = numero1 * 2;
                txtResultado1.Text = resultado.ToString();
            }else
            {
                resultado = numero1 * 3;
                txtResultado1.Text = resultado.ToString();
            }

            if (numero2 > 10 && numero2 < 100)
            
            {
                MessageBox.Show("Intervalo Permitido!");
            }
            if (numero3 < numero2)
            {
                resultado = numero3 - numero2;
                txtResultado3.Text = resultado.ToString();
            }
            else
            {
                resultado = numero3 + 1;
                txtResultado3.Text = resultado.ToString();
            }
        }
    }
}
