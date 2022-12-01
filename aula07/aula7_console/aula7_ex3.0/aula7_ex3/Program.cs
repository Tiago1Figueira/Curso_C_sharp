using System;

namespace aula7_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor inicial do intervalo:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor final do intervalo:");
            int b = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = a; i <= b; i++) 
            {
                Console.WriteLine(i);
            }         
                

            Console.ReadKey();

        }
    }
}
