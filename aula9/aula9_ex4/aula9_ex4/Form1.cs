using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula9_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bits = Convert.ToDouble(txtBits.Text);
            double bytes, kbytes, megabytes, gygabytes, terabytes;

            bytes = bits / 8;
            kbytes = bytes / 1024;
            megabytes = kbytes / 1024;
            gygabytes = megabytes / 1024;
            terabytes = gygabytes / 1024;

            txtBytes.Text = bytes.ToString();
            txtKbytes.Text = kbytes.ToString();
            txtMegabytes.Text = megabytes.ToString();
            txtTerabytes.Text = terabytes.ToString();

        }
    }
}
