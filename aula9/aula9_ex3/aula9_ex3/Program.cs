using System;

namespace aula9_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSOLE E NÃO WINDOWS FORM!!!

            double metros, centimetros;
            Console.WriteLine("Informe o valor em quilômetros:");
            double km = Convert.ToDouble(Console.ReadLine());

            metros = km * 1000;
            centimetros = km * 100000;
            {
                Console.WriteLine(metros);
                Console.WriteLine(centimetros);
            }

            Console.ReadKey();

        }
    }
}
