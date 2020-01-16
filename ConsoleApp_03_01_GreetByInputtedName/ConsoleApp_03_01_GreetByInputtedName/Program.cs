using System;

//Greet by name inputted by user
namespace ConsoleAppGreetByName
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("Enter your name: ");

            var name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }
    }
}
