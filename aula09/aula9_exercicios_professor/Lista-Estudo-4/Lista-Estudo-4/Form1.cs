using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Estudo_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBits_TextChanged(object sender, EventArgs e)
        {
            if (txtBits.Text.Length != 0)
            {
                long bits = Convert.ToInt64(txtBits.Text);

                long bytes = bits / 8;
                long kbtyes = bytes / 1024;
                long megabytes = kbtyes / 1024;
                long terabytes = megabytes / 1024 / 1024;

                txtBytes.Text = bytes.ToString();
                txtKbytes.Text = kbtyes.ToString();
                txtMegabytes.Text = megabytes.ToString();
                txtTerabytes.Text = terabytes.ToString();
            } else
            {
                txtBytes.Text = "";
                txtKbytes.Text = "";
                txtMegabytes.Text = "";
                txtTerabytes.Text = "";
            }            
        }
    }
}
