using System;

namespace aula9_ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            double salarioreajustado, reajuste1 ;

            Console.WriteLine("Informe o seu salário mensal:");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor do reajuste em número inteiro:");
            double reajuste = Convert.ToDouble(Console.ReadLine());

            reajuste1 = reajuste / 100;

            salarioreajustado = salario + (salario * reajuste1);
            {
                Console.WriteLine("O valor do salário reajustado é" + salarioreajustado);
            }

            Console.ReadKey();


        }
    }
}
