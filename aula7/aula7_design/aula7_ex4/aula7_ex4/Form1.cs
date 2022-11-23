using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula7_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbTemperatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            double inicial = Convert.ToDouble(txtTempInicial.Text);
            double final = Convert.ToDouble(txtTempFinal.Text);
            int temperatura = Convert.ToInt32(cbTemperatura.Text);

            double far, kv, C, ;
            if (temperatura == 0)                 
            {
                far = (inicial * 1.8) + 32;
                txtTempFinal.Text = far + "°F".ToString();
            }
            if (temperatura == 1)
            {
                kv = inicial + 273.15;
                txtTempFinal.Text = kv + "°K".ToString();
            }
            if(temperatura == 2)
            {
                C = 5 / 9 * (inicial – 32);
                txtTempFinal.Text = C + "°C".ToString();
            }
        }
    }
}
