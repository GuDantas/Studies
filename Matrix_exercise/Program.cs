using System;

namespace Matrix_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] Matrix = new double[5, 5];
            for (int line = 0; line < 5; line++)
            {
                Matrix[line, 0] = line + 1;
                Console.WriteLine("Student {0}", line + 1);
                for(int coluna = 1; coluna < 5; coluna++)
                {
                    Console.WriteLine("Type the grade from the first bimester {0}",coluna);
                    Matrix[line, coluna] = Convert.ToDouble(Console.ReadLine());
                }
            } 
        }
    }
}
