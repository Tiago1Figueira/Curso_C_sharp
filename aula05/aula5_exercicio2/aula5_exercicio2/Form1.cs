using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula5_exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time1 = txtNomeTime1.Text;
            string time2 = txtNomeTime2.Text;
            int gols1 = Convert.ToInt32(txtGolsTime1.Text);
            int gols2 = Convert.ToInt32(txtGolsTime2.Text);

            if (gols1 > gols2)
            {
                MessageBox.Show("O time vencedor é:" + time1);

            }else if (gols1 < gols2)
            {
                MessageBox.Show("o time vencedor é:" + time2);
            }
            else
            {
                MessageBox.Show("Os dois empataram!");

            }


        }
    }
}
