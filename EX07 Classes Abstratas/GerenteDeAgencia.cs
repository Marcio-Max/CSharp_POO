using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07_Classes_Abstratas
{
    public class GerenteDeAgencia : Gerente
    {
        public override void Reajustar()
        {
            //base.Reajustar();
            this.Salario += 1200;
        }
    }
}
