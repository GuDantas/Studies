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
            Console.WriteLine("GAME OPTIONS");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("[1] - Rock");
            Console.WriteLine("[2] - Paper");
            Console.WriteLine("[3] - scissors");

            escolhaJogador = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            escolhaComputador = random.Next(1, 4);
            Console.WriteLine();
            Console.WriteLine("Computer´s choice " + escolhaComputador);
            Console.WriteLine();
            Console.WriteLine("Your´s choice " + escolhaJogador);
            Console.WriteLine();

            //if (escolhaJogador == escolhaComputador)
            //{
            //   Console.WriteLine("DRAW");
            //}
            //else if (escolhaJogador == 1 & escolhaComputador == 3) 
            //{
            //    Console.WriteLine("VICTORY");
            //}
            //else if (escolhaJogador == 2 & escolhaComputador == 1) 
            //{
            //    Console.WriteLine("VICTORY");
            //}
            //else if (escolhaJogador == 3 & escolhaComputador == 2)
            //    Console.WriteLine("VICTORY");
            //else
            //{
            //   Console.WriteLine("DEFEAT");
            //}
            switch (escolhaJogador)
            {
                case 1:
                    Console.WriteLine("You've choosen ROCK");

                    switch(escolhaComputador){ 
                        case 1:
                        Console.WriteLine("The Computer has choosen ROCK");
                        Console.WriteLine("That was a DRAW");
                        break;
                    case 2:
                        Console.WriteLine("The Computer has choosen PAPER");
                        Console.WriteLine("You has been DEFEATED");
                        break;
                    case 3:
                        Console.WriteLine("The Computer has choosen SCISSORS");
                        Console.WriteLine("You WON");
                        break;
                        
                    }
                    break;
                case 2:
                    Console.WriteLine("You've choosen PAPER");
                    switch (escolhaComputador)
                    {
                        case 1:
                            Console.WriteLine("The Computer has choosen ROCK");
                            Console.WriteLine("You WON");
                            break;
                        case 2:
                            Console.WriteLine("The Computer has choosen PAPER");
                            Console.WriteLine("That was a DRAW");
                            break;
                        case 3:
                            Console.WriteLine("The Computer has choosen SCISSORS");
                            Console.WriteLine("You has been DEFEATED");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("You've choosen SCISSORS");
                    switch (escolhaComputador)
                    {
                        case 1:
                            Console.WriteLine("The Computer has choosen ROCK");
                            Console.WriteLine("You has been DEFEATED");
                            break;
                        case 2:
                            Console.WriteLine("The Computer has choosen PAPER");
                            Console.WriteLine("You WON");
                            break;
                        case 3:
                            Console.WriteLine("The Computer has choosen SCISSORS");
                            Console.WriteLine("That was a DRAW");
                            break;
                    }
                    break;
            }
        }
    }
}
