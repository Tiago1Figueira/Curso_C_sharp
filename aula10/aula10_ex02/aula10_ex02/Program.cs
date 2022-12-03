using System;

namespace aula10_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, i;
            double fatorial;
            fatorial = 1; 

            Console.WriteLine("Insira um número inteiro:");
            numero = Convert.ToInt32(Console.ReadLine());


            if (numero <= 0)
            {
                Console.WriteLine("Você deve informar um número maior que 0 e inteiro!");
            }

            else
            {
                for (i = 1; i <= numero; i++)
                    fatorial = fatorial * i;
                    Console.WriteLine("Fatorial:" + fatorial);
            }
            

            Console.ReadKey();

        }
    }
}
