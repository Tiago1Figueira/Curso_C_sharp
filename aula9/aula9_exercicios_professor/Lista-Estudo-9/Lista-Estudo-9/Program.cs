using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Estudo_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, numeroFilhos;
            double mediaSalario, mediaNumeroFilhos, maiorSalario, percentualSalarioBaixo;
            double pessoas, pessoasSalarioBaixo, totalSalarios, totalNumeroFilhos;

            pessoas = 0;
            pessoasSalarioBaixo = 0;
            maiorSalario = 0;
            totalSalarios = 0;
            totalNumeroFilhos = 0;

            do
            {
                Console.WriteLine("Entre com o salário:");
                salario = Convert.ToDouble(Console.ReadLine());

                if (salario > 0)
                {
                    Console.WriteLine("Entre com o número de filhos:");
                    numeroFilhos = Convert.ToDouble(Console.ReadLine());

                    pessoas++;
                    totalSalarios += salario;
                    totalNumeroFilhos += numeroFilhos;

                    if (salario > maiorSalario)
                    {
                        maiorSalario = salario;
                    }

                    if (salario <= 1000)
                    {
                        pessoasSalarioBaixo++;
                    }
                }
            } while (salario > 0);

            mediaSalario = totalSalarios / pessoas;
            Console.WriteLine("Média de Salário da População: " + mediaSalario.ToString("N2"));

            mediaNumeroFilhos = totalNumeroFilhos / pessoas;
            Console.WriteLine("Média do Número de Filhos da População: " + mediaNumeroFilhos.ToString("N1"));
            
            Console.WriteLine("Maior Salário: " + maiorSalario.ToString("N2"));

            percentualSalarioBaixo = pessoasSalarioBaixo / pessoas * 100;
            Console.WriteLine("Percentual de pessoas com salário até 1000: " + percentualSalarioBaixo.ToString("N2") + "%");

            Console.ReadKey();
        }
    }
}
