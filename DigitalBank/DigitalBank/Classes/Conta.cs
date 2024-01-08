using DigitalBank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Classes
{
    //Conta e uma classe Modelo(Abstrata) que herda da classe Banco e implementa a interface Iconta 
    /*
      Uma classe abstrata é uma classe que não pode ser instanciada diretamente. Ela geralmente contém métodos abstratos, que são métodos sem implementação.
      As subclasses que herdam dessa classe abstrata são obrigadas a implementar esses métodos abstratos. Além dos métodos abstratos, uma classe abstrata pode 
      conter métodos concretos (com implementação) e atributos. Ela fornece uma estrutura comum para suas subclasses.
     */
    public abstract class Conta : Banco, IConta
    {
        //CONSTRUTOR com Atributos pre-definidos
        public Conta()
        {
            this.NumeroDaAgencia = "0001";
            Conta.NumeroDaContaSequencial++;
        }
        
        //Atributos
        public double Saldo { get; protected set; }
        public string NumeroDaAgencia { get; private set; }
        public string NumeroConta { get; protected set; }

        //Metodo estatico pertenci a classe e nao ao objeto
        public static int NumeroDaContaSequencial { get; private set; }



        //Emplementacao dos contratos(Metodos) da interface Iconta
        public double ConsultSaldo()
        {
            return this.Saldo;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if (valor > this.ConsultSaldo())
                return false;

            this.Saldo -= valor;
            return true;
        }

        public string CodegoDoBanco()
        {
           return this.CodigoDoBanco;
        }
        public string GetNumeroDaAgencia()
        {
            return this.NumeroDaAgencia;
        }

        public string GetNumeroDaConta()
        {
            return this.NumeroConta;
        }

       

    }
}
