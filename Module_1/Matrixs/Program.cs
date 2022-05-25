using System;

namespace Matrixs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixA = new int[5];
            int[] matrixB = new int[5];
            int[] matrixC = new int[5];
            for (int i = 0; i < matrixA.Length; i++)
            {
                Console.WriteLine("Type the value {0} from Matrix A", i);
                matrixA[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < matrixB.Length; i++)
            {
                Console.WriteLine("Type the value {0} from Matrix B", i);
                matrixB[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < matrixC.Length; i++)
            {
                matrixC[i] = matrixA[i] * matrixB[i];
                Console.WriteLine("{0} X {1} = {2}", matrixA[i], matrixB[i], matrixC[i]);
            }
        }
    }
}
