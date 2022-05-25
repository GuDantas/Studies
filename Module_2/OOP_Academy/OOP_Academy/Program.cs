using System;

namespace OOP_Academy
{
    internal class Program
    {
        // first class of oop, just the introduction to the basic
        static void Main(string[] args){ 
            Address  address = new Address();
            Customer customer_me = new Customer();
            customer_me._name = "Gustavo";
            customer_me._age = 17;
            customer_me._height = 1.72f;

            address.Street = "Av Brasil";
            address.City = "São Paulo";
            address.Number = "1620";
            address.PostalCode = "12345-678";

            Console.WriteLine(customer_me._name);
            
        }
    
    }
}

