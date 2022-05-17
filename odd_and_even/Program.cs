using System;

namespace odd_and_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is a program that distinguish odd numbers from even numbers
            int[] par = new int[15];
            int[] impar = new int[15];
            int[] geral = new int[15];
            int iPar = 0, iImpar = 0, valor = 0;
            
            for(int i = 0; i < geral.Length; i++)
            {
                Console.WriteLine("Type the value for position {0}",i);
                valor = Convert.ToInt32(Console.ReadLine());
                geral[i] = valor;
                if( valor % 2 == 0)
                {
                    par[iPar] = valor;
                    iPar++;
                }
                else{
                    impar[iImpar] = valor;
                    iImpar++;

                }


            }
            Console.WriteLine("*****ALL NUMBERS*****");
            for(int i = 0; i < geral.Length; i++)
            {
                Console.WriteLine("{0} - {1}",i,geral);
            }
            Console.WriteLine("***** ODD NUMBERS*****");
            for(int i = 0; i < geral.Length; i++)
            {
                Console.WriteLine("{0} - {1}",i, impar);
            }
            Console.WriteLine("***** EVEN NUMBERS******");
            for(int i =0; i < geral.Length; i++){
                Console.WriteLine("{0} - {1}", par, iPar);
            }
            // This part of the program is to multiply two lists
            Console.WriteLine("Second part off the program, multiplying lists");
            
            }
        }
    }

