using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Escolha uma operação: ");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Multiplicacao");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Encerrar Programa");
                Console.WriteLine();

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao > 4)
                {
                    Console.WriteLine("Opcao Inválida");
                }

                if (opcao > 0 && opcao < 5)
                {
                    Console.WriteLine("Entre com o valor 1: ");
                    int v1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Entre com o valor 2: ");
                    int v2 = Convert.ToInt32(Console.ReadLine());

                    int resultado = 0;

                    switch(opcao)
                    {
                        case 1:
                            Console.WriteLine("Soma foi escolhida.");
                            resultado = v1 + v2;
                            break;
                        case 2:
                            Console.WriteLine("Subtracao foi escolhida.");
                            resultado = v1 - v2;
                            break;
                        case 3:
                            Console.WriteLine("Multiplicacao foi escolhida.");
                            resultado = v1 * v2;
                            break;
                        case 4:
                            Console.WriteLine("Divisao foi escolhida.");
                            resultado = v1 / v2;
                            break;
                    }

                    Console.WriteLine("Resultado = " + resultado.ToString());
                }
            } while (opcao != 0);

        }
    }
}
