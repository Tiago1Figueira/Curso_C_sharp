using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            // for
            int inicio;

            // inicio++ é um atalho para inicio = inicio + 1, outra forma inicio += 1

            //for (< condição inicial > ; < critério de execução > ; < critério de incremento>)
            for (inicio = 1; inicio <= 100; inicio++)
            {
                // trecho ....
                Console.WriteLine(inicio);
            }

            // while <critério de execução>
            //inicio = 1;
            //while (inicio <= 100)
            //{
            //    Console.WriteLine(inicio);
            //    inicio++;
            //}

            // do while
            //inicio = 1;
            //do
            //{
            //    Console.WriteLine(inicio);
            //    inicio++;
            //} while (inicio <= 100);


            Console.ReadKey();
        }
    }
}
