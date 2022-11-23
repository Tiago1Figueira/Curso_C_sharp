using System;

namespace aula7_ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            for (i=53; i<=521; i++)
                if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
                        
        }
    }
}
