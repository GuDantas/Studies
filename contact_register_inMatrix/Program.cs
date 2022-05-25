using System;

namespace contact_register_inMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[,] lista = new string[5, 4];
            char response = 'Y';
            string[,] cadastro = new string[5, 4];
            int line = 0;
            while (response != 'N')
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Register Contact");
                Console.WriteLine("-----------------------------------");
                Console.Write("Type your name: ");
                string name = cadastro[line, 0] = Console.ReadLine();
                Console.Write("Type your telephone number");
                string number =cadastro[line, 1] = Console.ReadLine();
                Console.Write("Type your e-mail");
                string email = cadastro[line, 2] = Console.ReadLine();
                Console.Write("Type your ID");
                string id = cadastro[line, 3] = Console.ReadLine();

                line++;
                Console.Write("Do you wish to add another contact? (Y/N): ");
                response = Convert.ToChar(Console.ReadLine());
                
            }
            for(line = 0; line < 5; line++)
            {
                Console.WriteLine("Name: {0}, telephone number: {1}, e-mail: {2}, ID: {3}",cadastro[line, 0],cadastro[line,1],cadastro[line,2],cadastro[line,3]);
                
            }
        }
    }
}