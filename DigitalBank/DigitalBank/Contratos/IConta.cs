using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Contratos
{
    public interface IConta
    {
        /* 
          Uma interface é semelhante a uma classe abstrata, mas não pode conter implementações de métodos. Ela define apenas a assinatura dos métodos 
          (nome, parâmetros e tipo de retorno).
          Uma classe que implementa uma interface deve fornecer a implementação para todos os métodos da interface. Interfaces permitem a criação de contratos,
          garantindo que as classes que as implementam ofereçam determinados comportamentos.
        */

        void Deposita(double valor);
        bool Saca(double valor);
        double ConsultSaldo();
        string CodegoDoBanco();
        string GetNumeroDaAgencia();
        string GetNumeroDaConta();
    }
}
