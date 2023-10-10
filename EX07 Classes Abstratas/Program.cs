using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07_Classes_Abstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n --------- Abstract Class e Poliformismo ----------- \n");

            AnalistaDeTI analistaDeTI = new AnalistaDeTI();
            GerenteDeAgencia gerenteDeAgencia = new GerenteDeAgencia();
            GerenteDeTI gerenteDeTI = new GerenteDeTI();

            Gerente gerente = new Gerente();
            gerente.Salario = 7500;
            Console.WriteLine(" Salario do gerente e: " +  gerente.Salario);
            gerente.Reajustar(); //Chamada do metodo Abstrat
            gerente.Nome = " Marcio";
            gerente.Saudacoes(); //Chamada do metodo Normal
            Console.WriteLine(" Salario do gerente Reajustado e: " + gerente.Salario );

            Console.WriteLine("\n ---------------------------------------\n");

            analistaDeTI.Salario = 3000;
            Console.WriteLine(" Salario do Analista de TI e: " + analistaDeTI.Salario);
            analistaDeTI.Reajustar(); //Chamada do metodo Abstrat
            analistaDeTI.Nome = " Miranda";
            analistaDeTI.Saudacoes(); //Chamada do metodo Normal
            Console.WriteLine(" Salario do Analista de TI Reajustado e: " + analistaDeTI.Salario );


            Console.ReadKey();
        }
    }
}
