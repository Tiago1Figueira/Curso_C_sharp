using System;

namespace aula7_ex7
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            for (i=1; i<=100; i++)
                if(i % 2 != 0 && i % 5 == 0 )
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
