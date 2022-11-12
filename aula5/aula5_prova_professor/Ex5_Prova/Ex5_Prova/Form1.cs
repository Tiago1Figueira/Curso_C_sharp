using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5_Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPreco_Click(object sender, EventArgs e)
        {
            double peras = Convert.ToDouble(txtQddPeras.Text);

            if (peras >= 12)
            {
                MessageBox.Show("Preço: R$" + peras.ToString("N2"), "Resultado");
            } else
            {
                MessageBox.Show("Preço: R$" + (peras * 1.50).ToString("N2"), "Resultado");
            }
        }
    }
}
