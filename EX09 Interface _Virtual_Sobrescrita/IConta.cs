using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09_Interface__Virtual_Sobrescrita
{
    public interface IConta //Interface ela so tera metodos() sem implementacao ou seja contratos;
    {                     
        void Deposita(double valor);
        double ConsultaSaldoDisponivel();
        bool Sacar(double valor);
        double AdicionarLimite(double valor);
    }
}
