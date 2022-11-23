using System;

namespace aula7_ex6
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            for (i=521; i>=53; i--)
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            Console.ReadKey();
            
        }
    }
}
