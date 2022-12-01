using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string origem = cbOrigem.SelectedItem.ToString();
            string destino = "";

            if (cbDestino.SelectedIndex != -1)
            {
                destino = cbDestino.SelectedItem.ToString();
            }
            else
            {
                return;
            }

            if (origem.Equals(destino))
            {
                MessageBox.Show("Unidades Iguais, a conversão não pode ser feita.");
                txtResultado.Text = "";
                return;
            }
            else
            {
                double temperatura = Convert.ToDouble(txtTemperatura.Text);
                txtResultado.Text = converteTemperatura(temperatura, origem, destino).ToString();
            }
        }

        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            string destino = cbDestino.SelectedItem.ToString();
            string origem = "";

            if (cbOrigem.SelectedIndex != -1)
            {
                origem = cbOrigem.SelectedItem.ToString();
            } else
            {
                return;
            }

            if (origem.Equals(destino))
            {
                MessageBox.Show("Unidades Iguais, a conversão não pode ser feita.");
                txtResultado.Text = "";
                return;
            }
            else
            {
                double temperatura = Convert.ToDouble(txtTemperatura.Text);
                txtResultado.Text = converteTemperatura(temperatura, origem, destino).ToString();
            }
        }

        private double converteTemperatura(double temperatura, string origem, string destino)
        {
            string conversao = origem + "-" + destino;
            double resultado = 0;

            switch (conversao)
            {
                case "Celsius-Fahrenheit":
                    resultado = temperatura * 1.8 + 32;
                    break;
                case "Celsius-Kelvin":
                    resultado = temperatura + 273.15;
                    break;
                case "Kelvin-Fahrenheit":
                    resultado = 1.8 * (temperatura - 273.15) + 32;
                    break;
                case "Kelvin-Celsius":
                    resultado = temperatura - 273.15;
                    break;
                case "Fahrenheit-Celsius":
                    resultado = (5.0 / 9.0) * (temperatura - 32);
                    break;
                case "Fahrenheit-Kelvin":
                    resultado = (5.0 / 9.0) * (temperatura - 32) + 273.15;
                    break;
            }

            return resultado;
        }
    }
}
