using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula8_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valortotal = Convert.ToDouble(txtValorTotal.Text);


            double valorfinal = 0;
            double valorparcelado = 0;
            switch (cbButton.SelectedIndex)
            {
                case 0:
                    valorfinal = valortotal - (valortotal * 0.075);
                    break;

                case 1:
                    valorfinal = valortotal + (valortotal * 0.05);
                    valorparcelado = (valorfinal / 2);
                    break;

                case 2:
                    valorfinal = valortotal + (valortotal * 0.095);
                    valorparcelado = (valorfinal / 3);
                    break;

                case 3:
                    valorfinal = valortotal + (valortotal * 0.125);
                    valorparcelado = (valorfinal / 4);
                    break;
            }

            txtValorFinal.Text = valorfinal + "reais".ToString();
            txtValorParcelas.Text = valorparcelado + "reais".ToString();

        }
    }
}
