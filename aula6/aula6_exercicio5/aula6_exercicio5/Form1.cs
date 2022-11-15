using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6_exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double codigo = Convert.ToDouble(txtCodigo.Text);
            
            if (codigo == 3)
            {
                txtResultado.Text = "Triângulo".ToString();
            }
            else if (codigo == 4)
            {
                txtResultado.Text = "Quadrado".ToString();
            }
            else if (codigo == 5)
            {
                txtResultado.Text = "Pentágono".ToString();
            }
            else if (codigo == 6)
            {
                txtResultado.Text = "Hexágono".ToString();
            }
            else 
            {
                txtResultado.Text = "Forma Desconhecida!".ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtResultado.Text = "";

        }
    }
}
