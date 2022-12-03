using System;

namespace aula10_ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            int i;
            i = 1;

            Console.WriteLine("Informe o número que deseja a tabuada:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe quantos números você quer que a tabuada tenha:");
            num2 = Convert.ToInt32(Console.ReadLine());
                       
            for (i = 1; i <= num2; i++) 
                Console.WriteLine(num1 + "x" + i + "=" + num1 * i);
                                       
            
            Console.ReadKey();

        }
    }
}
