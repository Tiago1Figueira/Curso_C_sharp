using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula5_exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero_peras = Convert.ToDouble(txtNumeroPeras.Text);
            
            double custo_total;

            if (numero_peras >= 12) 

            {
                custo_total = numero_peras * 1;
                txtCustoTotal.Text = custo_total.ToString();
            }

            else if (numero_peras < 12)
            {
                custo_total = numero_peras * 1.5;
                txtCustoTotal.Text = custo_total.ToString();
            }
        }
    }
}
