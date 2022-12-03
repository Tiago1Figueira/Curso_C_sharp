using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula10.ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValorInicial.Text);
            double valor2 = Convert.ToDouble(txtValorFinal.Text);

            double i;
            double somaNumeroPares, somaNumeroImpares, somaTotal;
            somaNumeroPares = 0;
            somaNumeroImpares = 0;
            somaTotal = 0;

            for ( i=valor1; i<=valor2; i++)
            {
                if (i % 2 == 0)
                    somaNumeroPares += i;

                if (i % 2 != 0)
                    somaNumeroImpares += i;
                somaTotal = somaNumeroPares + somaNumeroImpares;

            }
            txtSomaImpares.Text = somaNumeroImpares.ToString();
            txtSomaPares.Text = somaNumeroPares.ToString();
            txtSomaTotal.Text = somaTotal.ToString();

            









        }
    }
}
