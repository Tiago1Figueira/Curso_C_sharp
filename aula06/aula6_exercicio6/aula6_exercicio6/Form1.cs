using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6_exercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(txtCelsius.Text);

            if (celsius == 0)
            {
                txtResultado.Text = "Zero Absoluto!".ToString();
            }
            else
            {
                txtResultado.Text = "Ainda não está em Zero Absoluto!".ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = "";
            txtResultado.Text = "";

        }
    }
}
