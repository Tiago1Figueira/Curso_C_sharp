using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Estudo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor de N:");
            double N = Convert.ToDouble(Console.ReadLine());
            double E = 1.0;

            for (double i = 1; i <= N; i++)
            {
                double fatorial_i = 1;

                for (double j = i; j > 1; j--)
                {
                    fatorial_i *= j;
                }

                E += (1 / fatorial_i);
            }

            Console.WriteLine("valor de E = " + E.ToString());
            Console.ReadKey();
        }
    }
}
