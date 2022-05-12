using System;

namespace Media2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media, frequencia, qntdAulas, qntdFaltas ;
            Console.WriteLine("This is a program that would be usefull for a teacher, to see if their students were approved or reproved");
            Console.WriteLine();
            Console.WriteLine("Type the first grade (0-100)");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second grade (0-100)");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the quantity off classes in the course");
            qntdAulas = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the quantity off absences");
            qntdFaltas = int.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            frequencia = 100 - (qntdFaltas / qntdAulas * 100);
            
            if (frequencia >= 75 && media >= 70){
                Console.WriteLine("You has been approved with grade {0} and presence from {1} %",media,frequencia);
            }
            else 
            {
                
                Console.WriteLine("You has been reproved with grade {0} and presence from {1} %", media,frequencia);
            }
        }
    }
}
