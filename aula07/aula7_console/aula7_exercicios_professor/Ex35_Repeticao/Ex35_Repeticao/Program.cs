using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 200; i <= 999; i++)
            {
                if (i % 2 == 0 && i % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
