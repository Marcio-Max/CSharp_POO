using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04_CONSTRUTORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Criando instancias da classe Conta
            Conta conta = new Conta(123, 400);

            Console.WriteLine("Quanto quer depositar?");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposita(deposito);

            Console.WriteLine("Quamto quer sacar?");
            double saque = double.Parse(Console.ReadLine());
            bool sacar = conta.Sacar(saque);

            //conta.AdicionarLimite(1500);
            //conta.Deposita(1500);
            //bool sacar = conta.Sacar(300);

            if (sacar)
            {
                Console.WriteLine(" Saque com SUCESSO!");
                Console.WriteLine(" O Saldo atual de: " + conta.ConsultaSaldoDisponivel());
                Console.WriteLine(" O numero da conta e:" + conta.Numero);
                Console.WriteLine(" O Limite e de padrao: " + conta.Limite);
                // Console.WriteLine(" O Limite e Adicionado: " + conta.AdicionarLimite());
                //Console.WriteLine(" O Saldo e de: " + conta.Saldo);
                //Console.WriteLine(" O Limite e de: " + conta.Limite);
                //Console.WriteLine(sacar);
            }


            Console.ReadKey();
        }
    }
}
