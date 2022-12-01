using System;
using System.Windows.Forms;

namespace Lista_Estudo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbDependentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSalarioBruto.Text.Length != 0 )
            {
                double salarioBruto = Convert.ToDouble(txtSalarioBruto.Text);
                double percentualAbono = 1.0;

                switch(cbDependentes.SelectedIndex)
                {
                    case 5:
                        percentualAbono = 1.15;
                        break;
                    default:
                        for (int i = 0; i < cbDependentes.SelectedIndex; i++)
                        {
                            percentualAbono += 0.03;
                        }
                        break;
                }

                double salarioLiquido = salarioBruto * percentualAbono;
                txtSalarioLiquido.Text = salarioLiquido.ToString();
            }
        }

        private void txtSalarioBruto_TextChanged(object sender, EventArgs e)
        {
            txtSalarioLiquido.Text = "";

            if (cbDependentes.SelectedIndex != -1 && txtSalarioBruto.Text.Length != 0)
            {
                double salarioBruto = Convert.ToDouble(txtSalarioBruto.Text);
                double percentualAbono = 1.0;

                switch (cbDependentes.SelectedIndex)
                {
                    case 5:
                        percentualAbono = 1.15;
                        break;
                    default:
                        for (int i = 0; i < cbDependentes.SelectedIndex; i++)
                        {
                            percentualAbono += 0.03;
                        }
                        break;
                }

                double salarioLiquido = salarioBruto * percentualAbono;
                txtSalarioLiquido.Text = salarioLiquido.ToString();
            }
        }
    }
}
