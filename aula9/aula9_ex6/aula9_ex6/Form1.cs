﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula9_ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorfabrica = Convert.ToDouble(txtCustoFabrica.Text);

            double valorfinal, distribuidor = 0.28, impostos = 0.45;

            valorfinal = valorfabrica + (valorfabrica * distribuidor) + (valorfabrica * impostos);

            txtValorConsumidor.Text = valorfinal + "reais".ToString();



        }
    }
}
