using System;
using Class4.Models;

namespace Class4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // reading schooling level
            Console.WriteLine("Type your schooling level, 1-(bachelor's) or 2-(technologist), (type the number)");
            int type = Convert.ToInt32(Console.ReadLine());
            //Reading instituition information
            Console.WriteLine("Type institution's name");
            string institution =  Console.ReadLine();
            //Information about the choosen course
            Console.WriteLine("Type the name of the course");
            var name =Console.ReadLine();
            Formation  formation;

            if(type == 1)
            {
                Console.WriteLine("Course Conclusion Paper");
                var paper = Console.ReadLine();
                
            }
        }
    }
}
