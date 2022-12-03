using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula10_ex04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void cbPagamentoVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valor, valorVista, valorFinal;
            double valorMemoria, valorProcessador, valorTela;
            
            valorMemoria = 0;
            valorProcessador = 0;
            valorTela = 0;
            valorVista = 0;
            
         if (cbMemoriaRam.SelectedIndex > -1 && cbProcessador.SelectedIndex > -1 && cbTamanhoTela.SelectedIndex > -1 && cbPagamentoVista.SelectedIndex > -1)                
            {
                    switch (cbMemoriaRam.SelectedIndex)
                    {
                    case 0:
                        valorMemoria = 250;
                        break;
                    case 1:
                        valorMemoria = 350;
                        break;
                    case 2:
                        valorMemoria = 599;
                        break;
                    }
                    switch (cbProcessador.SelectedIndex)
                    {
                        case 0:
                            valorProcessador = 400;
                            break;
                        case 1:
                            valorProcessador = 700;
                            break;
                        case 2:
                            valorProcessador = 1049;
                            break;
                    }
                    switch (cbTamanhoTela.SelectedIndex)
                    {
                        case 0:
                            valorTela = 400;
                            break;
                        case 1:
                            valorTela = 700;
                            break;
                        case 2:
                            valorTela = 1049;
                            break;

                   
                     }
                    valor = (valorMemoria + valorProcessador + valorTela);

                    switch (cbPagamentoVista.SelectedIndex)
                    {
                    case 0:
                        valorVista = valor - (valor * 0.075);
                        break;
                    case 1:
                        valorVista = 0.00;
                        break;             

                    }
                txtValorVista.Text = valorVista + "reais".ToString();
                txtValorFinal.Text = valor + "reais".ToString();

            }

            else 
            {
                MessageBox.Show("Favor não deixar qualquer campo em branco!!");
            }

            


        }
    }
}
