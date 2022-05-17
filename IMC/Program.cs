using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a BMI(Body Mass Index) Calulator");
            Console.WriteLine();
            Console.WriteLine("Type your weight");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type your height");
            double altura = Convert.ToDouble(Console.ReadLine());

            double IMC = peso / Math.Pow(altura, 2);


            if (IMC < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (18.6 < IMC && IMC < 24.9)
            {
                Console.WriteLine("Healthy weight");
            }
            else if (IMC > 25 && IMC < 29.9)
            {
                Console.WriteLine("Overweight");
            }
            else if (IMC > 30 && IMC < 34.9)
            {
                Console.WriteLine("Obesity grade I");
            }
            else if (IMC > 35 && IMC < 39.9)
            {
                Console.WriteLine("Obesity grade II");
            }
            else 
                Console.WriteLine("Morbid Obesity");
            }
        }   
	

	}


