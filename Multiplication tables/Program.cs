using System;

namespace Multiplication_tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char response = 'Y';
            int tabuada ;
            int i;
            i = 0;
            Console.WriteLine("-------------------------");
            Console.WriteLine("MULTIPLICATION TABLE");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("Type an integer to calculate the multiplication table");
            tabuada = Convert.ToInt32(Console.ReadLine());
            while(response != 'N')
                while(i <= 10)
                {
                    int result = tabuada * i;
                    Console.WriteLine("{0} X {1} = {2}",tabuada, i, result);
                    i++;
                }
                Console.WriteLine("Do you want to use the multiplication table again?");
                response = Convert.ToChar(Console.ReadLine());
            
        }
    }
}
