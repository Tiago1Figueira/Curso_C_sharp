using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula10_ex_modelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Aula8_ex1 calculadora

            //private void btnCalcular_Click(object sender, EventArgs e)
            //{
            //    double valor1 = Convert.ToDouble(txtValor1.Text);
            //    double valor2 = Convert.ToDouble(txtValor2.Text);

            //    if (rbSoma.Checked)
            //    {
            //        txtResultado.Text = (valor1 + valor2).ToString();
            //    }
            //    else if (rbSubtracao.Checked)
            //    {
            //        txtResultado.Text = (valor1 - valor2).ToString();
            //    }
            //    if (rbMultiplicacao.Checked)
            //    {
            //        txtResultado.Text = (valor1 * valor2).ToString();
            //    }
            //    if (rbDivisao.Checked)
            //    {
            //        txtResultado.Text = (valor1 / valor2).ToString();
            //    }

            //aula9_ex1 calculo dependencia

            //private void cbDependentes_SelectedIndexChanged(object sender, EventArgs e)
            //{
            //    double salarioBruto = Convert.ToDouble(txtSalarioBruto.Text);
            //    double abonoDependentes0, abonoDependentes1, abonoDependentes2, abonoDependentes3, abonoDependentes4;
            //    double salarioFinal;

            //    abonoDependentes0 = 0.03;
            //    abonoDependentes1 = 0.06;
            //    abonoDependentes2 = 0.09;
            //    abonoDependentes3 = 0.12;
            //    abonoDependentes4 = 0.15;
            //    salarioFinal = 0;

            //    if (salarioBruto <= 0)
            //    {
            //        MessageBox.Show("O valor do salário deve ser positivo e maior que 0!");
            //    }

            //    if (salarioBruto > 0)
            //    {

            //        switch (cbDependentes.SelectedIndex)
            //        {
            //            case 0:  // para 1 dependente
            //                salarioFinal = salarioBruto + (salarioBruto * abonoDependentes0);
            //                break;

            //            case 1: // para 2 dependente
            //                salarioFinal = salarioBruto + (salarioBruto * abonoDependentes1);
            //                break;

            //            case 2: // para 3 dependente
            //                salarioFinal = salarioBruto + (salarioBruto * abonoDependentes2);
            //                break;

            //            case 3: // para 4 dependente
            //                salarioFinal = salarioBruto + (salarioBruto * abonoDependentes3);
            //                break;

            //            case 4: // para 5 ou + dependente
            //                salarioFinal = salarioBruto + (salarioBruto * abonoDependentes4);
            //                break;
            //        }

            //    }

            //    txtSalarioFinal.Text = salarioFinal + "reais".ToString();


            //aula9_ex2  calculo imposto

            //        private void cbEmbalagemEspecial_SelectedIndexChanged(object sender, EventArgs e)
            //        {
            //            double valorProduto = Convert.ToDouble(txtValorProduto.Text);
            //            double quantidade = Convert.ToDouble(txtQuantidadeVendida.Text);
            //            double valorLiquido, valorBruto;
            //            double acrescimo, valorFinal, percentualEmbalagem;
            //            double animal, vegetal, outros, embalagem;

            //            animal = 0.15;
            //            vegetal = 0.10;
            //            outros = 0.043;
            //            embalagem = 0.077;
            //            acrescimo = 0;
            //            percentualEmbalagem = 0;
            //            valorFinal = 0;

            //            valorBruto = valorProduto * quantidade;
            //            switch (cbOrigem.SelectedIndex)
            //            {
            //                case 0:
            //                    acrescimo = valorBruto * animal;
            //                    break;
            //                case 1:
            //                    acrescimo = valorBruto * vegetal;
            //                    break;
            //                case 2:
            //                    acrescimo = valorBruto * outros;
            //                    break;
            //            }
            //            valorLiquido = valorBruto + acrescimo;

            //            switch (cbEmbalagemEspecial.SelectedIndex)
            //            {
            //                case 0:
            //                    percentualEmbalagem = valorLiquido * (embalagem * quantidade);
            //                    valorFinal = valorLiquido + percentualEmbalagem;
            //                    break;

            //                case 1:
            //                    percentualEmbalagem = 0;
            //                    valorFinal = valorLiquido + percentualEmbalagem;
            //                    break;

            //                    if (cbOrigem.SelectedIndex < 0)

            //                    {
            //                        MessageBox.Show("Você deve escolher a origem do produto primeiramente!");
            //                        cbEmbalagemEspecial.SelectedItem = -1;
            //                    }

            //            }

            //            txtValorLiquido.Text = valorLiquido + "reais".ToString();
            //            txtAcrescimo.Text = acrescimo + "reais".ToString();
            //            txtValorBruto.Text = valorBruto + "reais".ToString();
            //            txtValorFinal.Text = valorFinal + "reais".ToString();

            //        }
            //    }
            //}


            //aula9_ex6 custo de fabrica

            //private void btnCalcular_Click(object sender, EventArgs e)
            //{
            //    double valorfabrica = Convert.ToDouble(txtCustoFabrica.Text);

            //    double valorfinal, distribuidor = 0.28, impostos = 0.45;

            //    valorfinal = valorfabrica + (valorfabrica * distribuidor) + (valorfabrica * impostos);

            //    txtValorConsumidor.Text = valorfinal + "reais".ToString();

//            aula9_ex7

//            private void btnCalcular_Click(object sender, EventArgs e)
//            {
//                int numcarros = Convert.ToInt32(txtCarrosVendidos.Text);
//                double totalvendas = Convert.ToDouble(txtTotalVendas.Text);
//                double salfixo = Convert.ToDouble(txtSalarioFixo.Text);
//                double comissaofixa = Convert.ToDouble(txtComissaoFixa.Text);

//                double salfinal;

//                salfinal = salfixo + (totalvendas * 0.05) + (numcarros * comissaofixa);

//                txtSalarioFinal.Text = salfinal + "reais".ToString();


//            }
//        }
//   }

//            aula9_ex9 (comand line - população)

//                double mediaSalario, mediaFilhos, maiorSalario, percentualSalarioBaixo;
//            double totalSalario, salario;
//            int contagemPessoas, contagemSalario, numeroFilhos, totalNumeroFilhos;

//            contagemPessoas = 0;
//            contagemSalario = 0;
//            totalSalario = 0;
//            maiorSalario = -9999;
//            totalNumeroFilhos = 0;


//            do
//            {
//                Console.WriteLine("Qual é o seu salário:");
//                salario = Convert.ToDouble(Console.ReadLine());

//                Console.WriteLine("Quantos filhos você tem:");
//                numeroFilhos = Convert.ToInt32(Console.ReadLine());


//                //verificação do maior salario

//                if (maiorSalario < salario)
//                    maiorSalario = salario;

//                //verificação média salario população
//                if (salario >= 0)
//                {
//                    totalSalario += salario;
//                    contagemPessoas += 1;
//                    totalNumeroFilhos += numeroFilhos;
//                }

//                //verificação do percentual de pessoal com sal <=1000
//                if (salario <= 1000 && salario > 0)
//                    contagemSalario += 1;

//                mediaSalario = totalSalario / contagemPessoas;  //verificação média salario população
//                percentualSalarioBaixo = (contagemSalario * 100) / contagemPessoas; //verificação do percentual de pessoal com sal <=1000
//                mediaFilhos = totalNumeroFilhos / contagemPessoas; //verificação media números de filhos


//            } while (salario >= 0);

//            Console.WriteLine("A média dos salários da população é:" + mediaSalario);
//            Console.WriteLine("O número médio de filhos por pessoa é:" + mediaFilhos);
//            Console.WriteLine("O maior salário é:" + maiorSalario + "reais.");
//            Console.WriteLine("O percentual de pessoas com o salário de até $1000 reais é:" + percentualSalarioBaixo + "%");

//            Console.ReadKey();

//        }
//    }
//}