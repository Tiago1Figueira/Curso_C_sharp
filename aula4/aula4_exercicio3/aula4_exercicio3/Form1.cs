using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4_exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnulo_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtNumero.Text);
            if (numero == 0)
            {
                MessageBox.Show("O número é nulo!");
            }else
            {
                MessageBox.Show("O número não é nulo!");
            }
        }
    }
}
