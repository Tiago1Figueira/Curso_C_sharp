using System;

namespace aula7_ex8
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            for (i=100; i<=1000; i++)
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }


            Console.ReadKey();
           
        }
    }
}
