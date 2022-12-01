using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int anos = Convert.ToInt32(txtAnos.Text);
            int meses = Convert.ToInt32(txtMeses.Text);
            int dias = Convert.ToInt32(txtDias.Text);

            int idade = anos * 365 + meses * 30 + dias;

            MessageBox.Show("Você tem " + idade + " dias de vida!", "Resultado");
        }
    }
}
