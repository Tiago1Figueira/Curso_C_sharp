using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor inicial: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o valor final: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Resultado:");
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
