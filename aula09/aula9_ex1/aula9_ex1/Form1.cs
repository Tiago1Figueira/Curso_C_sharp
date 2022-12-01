using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula9_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbDependentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            double salarioBruto = Convert.ToDouble(txtSalarioBruto.Text);
            double abonoDependentes0, abonoDependentes1, abonoDependentes2, abonoDependentes3, abonoDependentes4;
            double salarioFinal;

            abonoDependentes0 = 0.03;
            abonoDependentes1 = 0.06;
            abonoDependentes2 = 0.09;
            abonoDependentes3 = 0.12;
            abonoDependentes4 = 0.15;
            salarioFinal = 0; 

            if (salarioBruto <= 0)
            {
                MessageBox.Show("O valor do salário deve ser positivo e maior que 0!");
            }

            if ( salarioBruto > 0)
            {
               
                switch (cbDependentes.SelectedIndex)
                {
                    case 0:  // para 1 dependente
                        salarioFinal = salarioBruto + (salarioBruto * abonoDependentes0);
                        break;

                    case 1: // para 2 dependente
                        salarioFinal = salarioBruto + (salarioBruto * abonoDependentes1);
                        break;

                    case 2: // para 3 dependente
                        salarioFinal = salarioBruto + (salarioBruto * abonoDependentes2);
                        break;

                    case 3: // para 4 dependente
                        salarioFinal = salarioBruto + (salarioBruto * abonoDependentes3);
                        break;

                    case 4: // para 5 ou + dependente
                        salarioFinal = salarioBruto + (salarioBruto * abonoDependentes4);
                        break;
                }

            }         

            txtSalarioFinal.Text = salarioFinal + "reais".ToString();





        }
    }
}
