using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Estudo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double km, m, cm;

            Console.WriteLine("Entre com um valor em Kilometros (KM)");
            km = Convert.ToDouble(Console.ReadLine());

            m = km * 1000;
            cm = m * 100;

            Console.WriteLine("Convertido para metros (M): ");
            Console.WriteLine(m.ToString());
            Console.WriteLine("Convertido para centímetros (C): ");
            Console.WriteLine(cm.ToString());

            Console.ReadKey();
        }
    }
}
