using EX07_HERANCA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EX09_Interface__Virtual_Sobrescrita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Interfaces -----------");

           // Conta conta = new Conta(123, 0);
           Contapoupanca contapoupanca = new Contapoupanca(123, 400);

            contapoupanca.Deposita(100);
            contapoupanca.Sacar(10);
            double SaldoDisponivel = contapoupanca.ConsultaSaldoDisponivel();
            Console.WriteLine(" O saldo desponivel e de: " +  SaldoDisponivel + "$000");

            ContaCorrente contaCorrente = new ContaCorrente(345, 300.0);
            contaCorrente.Deposita(1000);
            contaCorrente.Sacar(137);
            double SaldoContaCorrente = contaCorrente.ConsultaSaldoDisponivel();
            Console.WriteLine(" O saldona conta corrente e de: " + SaldoContaCorrente + "$000");







            Console.ReadKey();
        }
    }
}
