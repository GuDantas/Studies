using System;

namespace MediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ANOTHER PROGRAM FOR TEACHERS
            Console.WriteLine("This is another program that would be usefull for a teacher");
            Console.WriteLine();
            Console.WriteLine("Type the grade from the first quarter (0-10)");
            double media1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the grade from the second quarter (0-10)");
            double media2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the grade from the second quarter (0-10)");
            double media3 = double.Parse(Console.ReadLine());

            double mediaFinal = (media1 + media2 + media3)/ 3;
            if (mediaFinal >= 7)
                {
                Console.WriteLine("You are approved with grade = " + mediaFinal);

            }
            else
            {
                Console.WriteLine("You are reproved with grade = " + mediaFinal);
            }
        }
    }
}
