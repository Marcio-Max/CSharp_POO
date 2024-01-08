using DigitalBank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Classes
{
    public class Pessoa 
    {
        //Atributos
        public string Nome {  get; private set; }
        public string Nif { get; private set; }
        public string Senha { get; private set; }
        public IConta Conta { get;  set; }


        //Metodos
        public void SetNome(string nome)
        { this.Nome = nome; }
        public void SetNif(string nif)
        { this.Nif = nif; }
        public void SetSenha(string senha)
        { this.Senha = senha;}

    }
}
