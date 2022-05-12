using System;

namespace MediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque a média do primeiro trimestre");
            double media1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Coloque a média do segundo trimestre");
            double media2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Coloque a média do terceiro trimestre");
            double media3 = double.Parse(Console.ReadLine());

            double mediaFinal = (media1 + media2 + media3)/ 3;
            if (mediaFinal >= 70)
                {
                Console.WriteLine("Você está aprovado com média = " + mediaFinal);

            }
            else
            {
                Console.WriteLine("Você está reprovado com média = " + mediaFinal);
            }
        }
    }
}
