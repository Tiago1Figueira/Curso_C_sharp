using System;

namespace aula9_ex9
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double mediaSalario, mediaFilhos, maiorSalario, percentualSalarioBaixo;
            double totalSalario, salario;            
            int contagemPessoas, contagemSalario, numeroFilhos, totalNumeroFilhos ;

            contagemPessoas = 0;        
            contagemSalario = 0;
            totalSalario = 0;
            maiorSalario = -9999;
            totalNumeroFilhos = 0;


            do
            { 
            Console.WriteLine("Qual é o seu salário:");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantos filhos você tem:");
            numeroFilhos = Convert.ToInt32(Console.ReadLine());
            
            
             //verificação do maior salario
                
             if (maiorSalario < salario)
                 maiorSalario = salario;
                
             //verificação média salario população
             if (salario >=0)
             {
                 totalSalario += salario;
                 contagemPessoas += 1;
                 totalNumeroFilhos += numeroFilhos;
             }
                   
             //verificação do percentual de pessoal com sal <=1000
             if (salario <= 1000 && salario > 0)
                 contagemSalario += 1;
               
             mediaSalario = totalSalario / contagemPessoas;  //verificação média salario população
             percentualSalarioBaixo = (contagemSalario * 100) / contagemPessoas ; //verificação do percentual de pessoal com sal <=1000
             mediaFilhos = totalNumeroFilhos / contagemPessoas; //verificação media números de filhos


            } while(salario >=0);

            Console.WriteLine("A média dos salários da população é:" + mediaSalario);
            Console.WriteLine("O número médio de filhos por pessoa é:" + mediaFilhos);
            Console.WriteLine("O maior salário é:" + maiorSalario + "reais.");
            Console.WriteLine("O percentual de pessoas com o salário de até $1000 reais é:" + percentualSalarioBaixo + "%");

            Console.ReadKey();
            
        }
    }
}
