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
            double salario = Convert.ToDouble(txtSalarioBruto.Text);



        }
    }
}
