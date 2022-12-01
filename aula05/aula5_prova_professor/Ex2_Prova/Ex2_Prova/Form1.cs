using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuemGanhou_Click(object sender, EventArgs e)
        {
            int golsA = Convert.ToInt32(txtGolsTimeA.Text);
            int golsB = Convert.ToInt32(txtGolsTimeB.Text);

            if (golsA > golsB)
            {
                MessageBox.Show("O time " + txtNomeTimeA.Text + " ganhou!", "Resultado!");
            } else if (golsB > golsA)
            {
                MessageBox.Show("O time " + txtNomeTimeB.Text + " ganhou!", "Resultado!");
            } else
            {
                MessageBox.Show("EMPATE!", "Resultado!");
            }
        }
    }
}
