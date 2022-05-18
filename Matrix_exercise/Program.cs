using System;

namespace Matrix_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a Matrix and Array exercise
            double[,] Matrix = new double[3, 5];
            for (int line = 0; line < 3; line++)
            {
                Matrix[line, 0] = line + 1;
                Console.WriteLine("Student {0}", line + 1);
                for(int coluna = 1; coluna < 5; coluna++)
                {
                    Console.WriteLine("Type the grade from the bimester {0}",coluna);
                    Matrix[line, coluna] = Convert.ToDouble(Console.ReadLine());
                }
            } 
            for(int line = 0; line < 3; line++)
            {
                for(int coluna = 1; coluna < 5; coluna++)
                {
                    double grade = line;
                    Console.WriteLine(line);
                    //double media = (z + z) / 4
                }
            }
        }
    }
}
