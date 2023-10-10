using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07_Classes_Abstratas
{
    public abstract class Funcionario //abstrat  essa classe nao pode ser instanciada
    {
        public  string Nome { get; set; }
        public decimal Salario { get; set; }


        public abstract void Reajustar(); //metodo Abstratct  e de implementacao obrigaria nas classes filhas  "herdeiras". 
                                          //polimorfismo esse metodo sera implementada de deferentes formas nas classes filhas
        public void Saudacoes() 
        {
            Console.WriteLine(" Ola seja bem vindo: " + this.Nome);
        }

    }
}
