using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07_HERANCA
{
    public class Contapoupanca : Conta
    {
        public Contapoupanca(int numero, double limite) : base(numero, limite) // Base "pega" o construtor da Classe herdada (Conta)
        {                                                                      // Base aqui e usada porque temos un construtor  criado na classe herdada Conta
            
        }
        // metodo interno somente da classe Contapoupanca
        public void MostarNumeroConta() 
        {
            Console.WriteLine(" O numero da conta Poupança e: " + this.Numero);
        }
    }
}
