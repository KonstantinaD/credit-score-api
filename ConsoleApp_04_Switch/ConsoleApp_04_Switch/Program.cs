using System;

namespace ConsoleApp_04_Switch
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number: ");

            string number = Console.ReadLine();

            Guess.ProcessGuess(Convert.ToInt32(number));

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
