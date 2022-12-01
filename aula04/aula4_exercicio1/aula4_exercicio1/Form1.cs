using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4_exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEpositivo_Click(object sender, EventArgs e)
        {
            //Desenvolver um programa que leia um número e indique se ele é positivo
            /*|| (representa o ou)
             * &&(representa o e)
             * ! (inverte verdadeiro em falso e vice-versa; e.g.(!(num > 0))
             * 
             */
            double numero = Convert.ToDouble(txtNumero.Text);
            if (numero > 0)
            {
                MessageBox.Show("Expressão Verdadeira!");
            } else
            {
                MessageBox.Show("Expressão Falsa!");
            }

        }
    }
}
