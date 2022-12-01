using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula8_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grpTempInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            double temp1 = Convert.ToDouble(txtTempInicial.Text);
            double temp2 = Convert.ToDouble(txtTempFinal.Text);
//3min



        }
    }
}
