using System;

namespace aula8_ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i=999; i<=2000; i++)
                if (i % 2 !=0 && i % 15 == 0)
                {
                    Console.WriteLine(i);
                }
            Console.ReadKey();

           
        }
    }
}
