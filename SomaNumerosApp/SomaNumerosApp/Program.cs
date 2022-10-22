using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaNumerosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* - Primeira versão do aplicativo de soma
            int a, b, soma;

            a = 2;
            b = 3;

            // Soma numérica +
            soma = a + b;

            // Concatenação de valores +
            Console.WriteLine("Soma = " + soma);
            Console.ReadKey();
            */

            /* - Segunda versão do aplicativo de soma
            int a, b, soma;

            Console.WriteLine("Entre com o primeiro valor:");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Entre com o segundo valor:");
            int.TryParse(Console.ReadLine(), out b);

            soma = a + b;

            Console.WriteLine("Soma = " + soma);
            Console.ReadKey();
            */

            // Terceira versão do aplicativo de soma
            int a, b, soma;

            int.TryParse(args[0], out a);
            int.TryParse(args[1], out b);

            soma = a + b;

            Console.WriteLine("Soma = " + soma);
            Console.ReadKey();
            //

        }
    }
}
