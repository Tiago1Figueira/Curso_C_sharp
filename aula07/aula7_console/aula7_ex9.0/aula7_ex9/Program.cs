using System;

namespace aula7_ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i=200; i<=999; i++)
                if (i % 2 == 0 && i % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            Console.ReadKey();
            
            
            
        }
    }
}
