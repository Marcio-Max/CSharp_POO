using Construtores;

Console.WriteLine("  CONSTRUTORES  ");

string nome1;
string nome2;
Console.WriteLine("Qual e o nome do Jogador1");
nome1 = Console.ReadLine();



Jogador jogador1 = new Jogador(nome1);
Jogador jogador2 = new Jogador("Mario Mendes");

Console.WriteLine("Energia do jogador1: {0} - Jogador1 chama-se: {1}", jogador1.energia, jogador1.getNome());
Console.WriteLine("Energia do jogador2: {0} - Jogador2 chama-se: {1}", jogador2.energia, jogador2.getNome());
