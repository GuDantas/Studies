using System;

namespace jokenpo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolhaJogador, escolhaComputador;
            Console.WriteLine("***************************");
            Console.WriteLine("******* J O K E N P O *****");
            Console.WriteLine("***************************");
            Console.WriteLine();
            Console.WriteLine("OPÇÔES DO JOGO");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("[1] - Pedra");
            Console.WriteLine("[2] - Papel");
            Console.WriteLine("[3] - Tesoura");

            escolhaJogador = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            escolhaComputador = random.Next(1, 4);
            
            if (escolhaComputador == escolhaComputador)
            {
                Console.WriteLine("EMPATE");
            }
        }
    }
}
