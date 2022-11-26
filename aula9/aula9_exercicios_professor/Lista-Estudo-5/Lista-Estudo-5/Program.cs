using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Estudo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o salário mensal: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o percentual de reajuste: ");
            double percentual = Convert.ToDouble(Console.ReadLine());

            double novoSalario = salario * (1 + percentual / 100);

            Console.WriteLine("Novo salário mensal: ");
            Console.WriteLine(novoSalario.ToString("N2"));
            Console.ReadKey();
        }
    }
}
