using System;

namespace aula9_ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor inteiro e positivo:");
            int n = Convert.ToInt32(Console.ReadLine());

            int i;
            double fatorial = 1, e = 0;
            for (i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
                e = e + (1 / fatorial);
            }                       
                Console.WriteLine("Fatorial:" + fatorial);
                Console.WriteLine("E = " + e);
            
            Console.ReadKey();


        }
    }
}
