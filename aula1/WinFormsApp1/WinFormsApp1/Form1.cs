using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblnum2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btSoma_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)

            {
                MessageBox.Show("Por favor, preencha os valores");
            }
            else
            {
                double valor1, valor2, resultado;

                double.TryParse(textBox1.Text, out valor1);
                double.TryParse(textBox2.Text, out valor2);

                if ()
                {
                    resultado = valor1 + valor2;
                    textBox3.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, preencha os valores");
                }
                if (is_valor1_ok && )
                resultado = valor1 + valor2;

                textBox3.Text = resultado.ToString();
            }
        }

         private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
