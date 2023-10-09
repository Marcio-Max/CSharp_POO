//using EX06_static_vs_instancia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06_static_vs_instancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   Propiedades e metodos STATICOS \n");

            Conta conta1 = new Conta(123, 300);
            Conta conta2 = new Conta(456, 300);
            Conta conta3 = new Conta(789, 900);

            Console.WriteLine($" A Conta numero: {conta1.Numero} tem um Limite de: {conta1.Limite} Dollares");
            Console.WriteLine($" A Conta numero: {conta2.Numero} tem um Limite de: {conta2.Limite} Dollares");
            Console.WriteLine($" A Conta numero: {conta3.Numero} tem um Limite de: {conta3.Limite} Dollares");
            Console.WriteLine(" Numero de contas Criadas: " + Conta.TotalContasCriadas);
            Console.WriteLine(" Proxima Conta criada sera o numero: " + Conta.ProximaContaCriada());

            Console.ReadKey();
        }
    }
}
