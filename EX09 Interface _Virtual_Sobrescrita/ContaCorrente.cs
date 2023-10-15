using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09_Interface__Virtual_Sobrescrita
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, double limite) : base(numero, limite)
        {

        }
    }
}
