using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Classes
{
    public abstract class Banco //(ABSTRATA) Serve como classe  Modelo
    {
        //Atributos
        public string NomeDoBanco { get; private set; }
        public string CodigoDoBanco { get; private set; }


        //Metodo Construtor com Atributos pre definidos
        public Banco() 
        {
            this.NomeDoBanco = "DigiBank";
            this.CodigoDoBanco = "027";
        }
    }
}
