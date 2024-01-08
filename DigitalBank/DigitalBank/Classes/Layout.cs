using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DigitalBank.Classes
{
    public class Layout // ''''''''''''''''''' ESSA CLASSE VAI CONTER TODOS OS METODOS ESTATICOS '''''''''''''''''''''''''''.
    {

        private static List<Pessoa> pessoas = new List<Pessoa>(); //Armazena as Pessoas criadas na variavel (do tipo Array list) chamada Pessoas
        private static int opcao = 0;
        public static void TelaPrincipal()  //Metodo para apresentar a Tela Menu Principal
        {
            //Aplicar a tela azul e letras brancas
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //Menu Inicial
            Console.WriteLine("\n                         -------- Digital Bank ---------            \n");
            Console.WriteLine("                           Digite a opcao desejada:                   \n");
            Console.WriteLine("                           1 - Criar Conta                            \n");
            Console.WriteLine("                           2 - Entra com o NIF                        \n");
            Console.WriteLine("                           3 - Sair da Aplicacao                      \n");
            Console.WriteLine("                         --------------------------------             \n");
            opcao =  int.Parse(Console.ReadLine());


            switch(opcao) 
            {
              case 1: TelaCriarConta();
                    break;
              case 2: TelaDeLogin();
                    break;
                case 3:
                    Console.WriteLine("    Ate a Proxima.");
                    Console.WriteLine("    Saindo...");
                    break;
                default: 
                    Console.WriteLine(" Opcao Invalida!");
                   // TelaPrincipal();
                    break;
            
            }
        }

        private static void TelaCriarConta()        //Metodo para apresentar Menu de criar conta
        {
            Console.Clear();

            Console.WriteLine("\n                         -------- Criar Conta ---------            \n");
            Console.WriteLine("                           Digite o seu nome:                        \n");
            string Nome = Console.ReadLine();
            Console.WriteLine("                           Digite o seu NIF:                         \n");
            string Nif = Console.ReadLine();
            Console.WriteLine("                           Digite a sua senha:                       \n");
            string Senha = Console.ReadLine();
            Console.WriteLine($"                          Nome: {Nome}  Nif: {Nif} Senha: {Senha}.  \n");
            Console.WriteLine("                         --------------------------------            \n");


            //Criar Conta
            ContaCorrente contaCorrente = new ContaCorrente();
            Pessoa pessoa = new Pessoa();
            pessoa.SetNome(Nome);
            pessoa.SetNif(Nif);
            pessoa.SetSenha(Senha);
            pessoa.Conta = contaCorrente;

            pessoas.Add(pessoa); //Adiciona um objeto(pessoa) no final da List<T> (pessoas)

            Console.Clear();
            Console.WriteLine("\n ----------------- Conta Cadastrada com SUCESSO! ----------------- ");

            //Espera 1 segundo depois avanca
            Thread.Sleep(1000);

            TelaContaLogada(pessoa);
        }

        private static void TelaDeLogin() //Metodo para apresentar a tela de Login
        {
            Console.Clear();

            Console.WriteLine("\n                         -------- Login ---------                 \n");
            
            Console.WriteLine("                           Digite o seu NIF:                         \n");
            String nif = Console.ReadLine();
            Console.WriteLine("                           Digite a sua senha:                       \n");
            String senha = Console.ReadLine();
            Console.WriteLine($"                          Nif: {nif} Senha: {senha}. \n ");
            Console.WriteLine("                         --------------------------------            \n");

            //Logar no Sistema
            //1 Buscar por Pesooa atravez do Nome e NIF
            Pessoa pessoa = pessoas.FirstOrDefault(x => x.Nif == nif && x.Senha == senha);
            if (pessoa != null)
            {
                //Tela Boas Vindas
                TelaBoasVindas(pessoa);

                //Tela Logada
                TelaContaLogada(pessoa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n ----------------- Pessoa nao Cadastrada! ----------------- \n");
            }
        }

        //Tela de Boas Vindas
        private static void TelaBoasVindas(Pessoa pessoa) 
        {
          string msgTelaBemVindo = 
                $" {pessoa.Nome} | Banco: {pessoa.Conta.CodegoDoBanco()}" +
                $"| Agencia: {pessoa.Conta.GetNumeroDaAgencia()} " +
                $"| Nº da Conta: {pessoa.Conta.GetNumeroDaConta()}";

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($" Seja bem Vindo, {msgTelaBemVindo} ");
            Console.WriteLine();


        }

        //Tela com Opcoes apos a pessoa estar logada
        private static void TelaContaLogada(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            
                                                        //Menu de operacoes apos Logar
           
            Console.WriteLine("\n                           Digite a opcao desejada:                       \n");
            Console.WriteLine("                           1 - Realizar Deposito                            \n");
            Console.WriteLine("                           2 - Realizar Saque                               \n");
            Console.WriteLine("                           3 - Consultar Saldo                              \n");
            Console.WriteLine("                           4 - Extrato                                      \n");
            Console.WriteLine("                           5 - SAIR                                         \n");
            Console.WriteLine("                         --------------------------------                   \n");
            opcao = int.Parse(Console.ReadLine( ));

            switch (opcao) 
            {
                case 1: 
                    TelaDeposito(pessoa);
                    break;
                case 2:
                    TelaSaque(pessoa);
                    break;
                case 3: 
                    TelaConsultaSaldo(pessoa);
                    break;
                case 4:
                    break;
                case 5: TelaPrincipal();
                    break;
                default: Console.WriteLine(" \n----- Opcao invalida -----\n");
                    break;

            }


        }

        private static void TelaDeposito(Pessoa pessoa) 
        {
            Console.Clear ();

            TelaBoasVindas (pessoa);

            Console.WriteLine("    Degite o Valor a depositar:    ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("_----------------_");

            pessoa.Conta.Deposita(valor);
            Console.Clear () ;
            
            TelaBoasVindas(pessoa);

            Console.WriteLine("                                         ");
            Console.WriteLine("     ------------------------------      ");
            Console.WriteLine("     Deposito Realizado com Sucesso      ");
            Console.WriteLine("     ------------------------------      ");
            Console.WriteLine("                                         ");
            Console.WriteLine("                                         ");

            OpcaoVoltarLogado (pessoa);
        }

        private static void OpcaoVoltarLogado(Pessoa pessoa)
        {
            Console.WriteLine("     Entre com uma das opcoes:           ");
            Console.WriteLine("     ------------------------------      ");
            Console.WriteLine("     1 - Voltar para minha conta         ");
            Console.WriteLine("     ------------------------------      ");
            Console.WriteLine("     2 - SAIR                            ");
            Console.WriteLine("     ------------------------------      ");
            opcao = int.Parse(Console.ReadLine());
              if(opcao == 1)
                  TelaContaLogada(pessoa);
              else
                  TelaPrincipal();
        }

        private static void OpcaoVoltarDeslogado()
        {
            Console.WriteLine("     Entre com uma das opcoes:           ");
            Console.WriteLine("     ------------------------------      ");
            Console.WriteLine("     1 - Voltar para minha conta         ");
            Console.WriteLine("     ------------------------------      ");
            Console.WriteLine("     2 - SAIR                            ");
            Console.WriteLine("     ------------------------------      ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
                TelaPrincipal();
            else
            {
                Console.WriteLine("            Opcao invalida!!!        ");
                Console.WriteLine("     ------------------------------      ");
            }
                
        }

        private static void TelaSaque(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("    Degite o Valor do Saque:    ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("_----------------_");

            bool okSaque = pessoa.Conta.Saca(valor);
            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("                                             ");
            if(okSaque ==  true)
            {
                Console.WriteLine("     ------------------------------      ");
                Console.WriteLine("     Saque realizado com Sucesso         ");
                Console.WriteLine("     ------------------------------      ");
            }
            else
            {
                Console.WriteLine("     ------------------------------      ");
                Console.WriteLine("     Saldo Insuficiente!                 ");
                Console.WriteLine("     ------------------------------      ");
            }
            Console.WriteLine("                                             ");
            Console.WriteLine("                                             ");

            OpcaoVoltarLogado(pessoa);
        }

        private static void TelaConsultaSaldo(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

           // Console.WriteLine("    Degite o Valor a depositar:    ");
            //double valor = double.Parse(Console.ReadLine());
            //Console.WriteLine("_----------------_");

            double SaldoDisponivel = pessoa.Conta.ConsultSaldo();
            Console.Clear();

            //TelaBoasVindas(pessoa);

            Console.WriteLine("                                              ");
            Console.WriteLine("     ------------------------------           ");
            Console.WriteLine($"     Saldo Disponivel: {SaldoDisponivel} $00 ");
            Console.WriteLine("     ------------------------------           ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");

            OpcaoVoltarLogado(pessoa);
        }


    }//Fim da Classe Layout

}//Fim da namespace DigitalBank.Classes
