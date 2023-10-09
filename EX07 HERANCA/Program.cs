using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07_HERANCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ----------- Herança ----------- \n ");

            Contapoupanca cp1 = new Contapoupanca(113, 0);
            cp1.Deposita(100);
            cp1.Sacar(10);
            double saldo = cp1.ConsultaSaldoDisponivel();
            cp1.MostarNumeroConta();
            Console.WriteLine(" Saldo da conta poupanca:" + saldo);
            Console.WriteLine("\n");


            Conta conta1 = new Conta(234, 100);
            conta1.MostarNumeroContaCorrente();
            Console.WriteLine(" quanto quer depositar na conta corrente? ");
            double deposita = double.Parse( Console.ReadLine());
            conta1.Deposita(deposita);

            Console.WriteLine(" Quanto quer sacar da conta corrente");
            double saca = double.Parse( Console.ReadLine());
            conta1.Sacar(saca);
            double SaldoContaCorrente = conta1.ConsultaSaldoDisponivel();
            Console.WriteLine(" Saldo da conta corrente: " + SaldoContaCorrente);



            Console.ReadKey();
        }
    }
}
