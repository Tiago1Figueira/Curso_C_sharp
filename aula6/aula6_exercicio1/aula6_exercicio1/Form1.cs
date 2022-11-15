using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6_exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(txtCelsius.Text);
            double kevin;

            kevin = celsius + 273.15;

            txtKevin.Text = kevin + "k".ToString();



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = "";
            txtKevin.Text = "";
        }
    }
}
