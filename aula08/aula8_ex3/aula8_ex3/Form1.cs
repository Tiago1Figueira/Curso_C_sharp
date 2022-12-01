using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula8_ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMudar_Click(object sender, EventArgs e)
        {

            string cor = cbCores.SelectedItem.ToString();

            if (cor.Equals("Azul"))
            {
                this.BackColor = Color.Blue;
            }

            else if (cor.Equals("Amarelo"))
            {
                this.BackColor = Color.Yellow;
            }

            else if (cor.Equals("Vermelho"))
            {
                this.BackColor = Color.Red;
            } 

            else if (cor.Equals("Verde"))
            {
                this.BackColor = Color.Green;
            }
            else if (cor.Equals("Branco"))
            {
                this.BackColor = Color.White;
            }

        }
    }
}
