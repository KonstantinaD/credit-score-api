using System;
using System.Collections.Generic;

//Greet everyone in the room by name
namespace ConsoleAppGreetByName
{
    public class Program
    {
        public static void Main()
        {

            List<string> names = new List<string>() { "Ana", "Lili", "Pete", "Mario", "John" };

            foreach (string name in names)
            {

                Console.WriteLine($"Hello {name}!");

            }

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }
    }
}
