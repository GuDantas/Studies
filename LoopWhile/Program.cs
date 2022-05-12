using System;

namespace LoopWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("This is a odd number finder");
            Console.WriteLine();
            Console.WriteLine("Input any real and integer number");
            x = Convert.ToInt32(Console.ReadLine());
            y = 0;
            while(y < x )
            {
                y++;
                z = y % 2;
                if (z == 0)
                { 
                Console.WriteLine(y);
                }
                else { }
            }
        }
    }
}
