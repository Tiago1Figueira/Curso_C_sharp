using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 999; i <= 2000; i++)
            {
                if (i % 2 != 0 && i % 15 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
