using System;

namespace Matrix_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a Matrix and Array exercise
            double grade;
           
            double[,] Matrix = new double[3, 5];
            for (int line = 0; line < 3; line++)
            {
                Matrix[line, 0] = line + 1;
                Console.WriteLine("Student {0}", line + 1);
                for (int o = 1; o < 5; o++)
                {
                    int coluna = 0;
                    Console.WriteLine("Type the grade from the bimester {0}", o);
                    Matrix[line, coluna] = Convert.ToDouble(Console.ReadLine());
                    grade = coluna;
                }

            }
           
        }
    }       
}
    
