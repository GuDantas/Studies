using System;

namespace Media2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media, frequencia, qntdAulas, qntdFaltas ;
            

            Console.WriteLine("Digite a nota da primeira prova");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da segunda prova");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de aulas do curso");
            qntdAulas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de faltas");
            qntdFaltas = int.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            frequencia = 100 - (qntdFaltas / qntdAulas * 100);
            
            if (frequencia >= 75 && media >= 70){
                Console.WriteLine("Você foi aprovado com nota " + media + " e frequencia " + frequencia + "%");
            }
            else
            {
                Console.WriteLine("Você foi reprovado com nota " + media + " e frequencia " + frequencia + "%");
            }
        }
    }
}
