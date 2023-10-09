using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06_static_vs_instancia
{
    public class Conta
    {
        //Construutor
        public Conta(int numero, double limite)
        {
            this.Numero = numero;
            this.Limite = limite;
            Conta.TotalContasCriadas++;
        }

        //Propiedades
        private double Saldo { get; set; }
        public double Limite { get; private set; } //Limite de credito que o Banco disponibilisa a um cliente!
        public int Numero { get; set; }
        public static int TotalContasCriadas { get; set; } //Atributo STACTIC pertence a CLASSE e nao a Instancia

        //Metodos
         public static int ProximaContaCriada() // metodo statico pertence a CLASSE e nao a Instancia
        {
            return TotalContasCriadas + 1;
        }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
         
        public double ConsultaSaldoDisponivel()
        {
            return Saldo + Limite;
        }

        public double AdicionarLimite( double valor )
        {
            return  Limite = valor;
        }

        public bool Sacar( double valor )
        {
            double saldoDisponivel = ConsultaSaldoDisponivel();
            if(saldoDisponivel < valor)
            {
                Console.WriteLine(" Saldo e saque Indisponivel!");
                return false;

            }else Saldo -= valor;
            return true;   
           
        }
    }
}
