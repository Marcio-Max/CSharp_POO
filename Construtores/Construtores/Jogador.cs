using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public  class Jogador
    {
        private string Nome { get; set; }
        public int energia;
        public bool vivo;

        public Jogador(string nome)
        {
            this.Nome = nome;
            energia = 100;  //energia = 100;
            vivo = true;    //vivo = true;
        }

        public string getNome() 
        {
            return Nome;
        }

    }
}
