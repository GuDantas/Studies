using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura");
            double altura = Convert.ToDouble(Console.ReadLine());

            double IMC = peso / Math.Pow(altura, 2);


            if (IMC < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (18.6 < IMC && IMC < 24.9)
            {
                Console.WriteLine("Peso Saúdavel");
            }
            else if (IMC > 25 && IMC < 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (IMC > 30 && IMC < 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if (IMC > 35 && IMC < 39.9)
            {
                Console.WriteLine("Obesidade grau II");
            }
            else ;
                Console.WriteLine("Obesidad Morbida");
            }
        }   
	

	}


