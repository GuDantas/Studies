using System;

namespace Class2_banking_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your CPF/ID");
            var cpf = Console.ReadLine();
            Console.WriteLine("Enter your telephone");
            var telepone = Console.ReadLine();

            decimal limit = 0;
            char especial = 'N';
            Console.WriteLine("Enter the account number");
            var acc_ID = Console.ReadLine();
            Console.WriteLine("Is your account especial");
            Convert.ToChar(Console.ReadLine());

            if(especial == 'Y')
            {
                
            }
        }
    }
}
