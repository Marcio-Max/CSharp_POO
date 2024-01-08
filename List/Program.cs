namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -- Colecoes ( List ) -- ");
            Console.WriteLine();

            /*Colecao list< > usada para substituir um Array tradicional, Pode ser intendido como um Array dinamico
             * no C# possui muitos metodos ja emplementados
             * pode ser usada com for iche
             *Pode ser intendido como um Array dinamico
             *
             */

              List<string> Carros = new List<string>();   //Criacao de uma List do tipo <string> com nome Carros
              List<string> Carros2 = new List<string>();
              string[] Carros3 = new string[10];          //Array Carros3 de 6 posicoes

              Carros.Add("Golf");                           // Carros.Add adiciona elementos a list Carros
              Carros.Add("HRV");
              Carros.Add("Focus"); 
              Carros.Add("Argo");
              Carros.Add("HRV");


            //Carros.Remove(Carros[1]);
            //Carros.RemoveAt(0);
            //Carros.Reverse();
            //Carros.Sort();
            //Carros.Insert(1, "Cruse");                    //Inseri na posicao escolhida o elemnto Cruse

            int Posicao = 0;
            Posicao = Carros.LastIndexOf("HRV");
            Console.WriteLine($" A utima posicao do Carro HRV e a posicao: {Posicao}");
            Console.WriteLine();
            foreach (var carro in Carros) 
            {
                Console.WriteLine(carro);
            }

            //Carros.Clear(); metodo clear para limpar
            Console.WriteLine(); 

            //AddRange copia para a list Carros2  itens da List Carros
            //Carros2.AddRange(Carros);
            foreach (string carro in Carros2)
            {
                Console.WriteLine($"Carros na lista Carros2 {carro}");
            }

            Console.WriteLine();

            if (Carros.Contains("HRV")) //contains() Retorna true ou false
            {
                Console.WriteLine($"  Esta presente na list !");
            }
            else 
            {
                Console.WriteLine($" Nao esta presente na List ");
            }

            Console.WriteLine();

            Carros.CopyTo(Carros3, 2);
            Carros.Insert(2, "Cruse");
            foreach (string carro in Carros3)
            {
                Console.WriteLine(" Carros3 {0} ",carro); 
            }
            
            Console.WriteLine();

            string car = "Focus";                                     //IndexOf retorna a posicao (index) de um elemnto
            int position = 0;
            position = Carros.IndexOf(car);
            Console.WriteLine( $" Carro: {car} esta na posicao: {position}");
            
            int Tamaho = Carros.Count;                                //Propiedade Count retorna quantidade de elemnt na list
            Console.WriteLine($" A list Carros tem tamanho: {Tamaho}");

            int Capacidade = Carros.Capacity; // = 20;                //Propiedade Capacity retorna ou determina a capacidade da list
            Console.WriteLine($" A list Carros tem Capacidade: {Capacidade}");

        }
    }
}
