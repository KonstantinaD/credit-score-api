using System;

namespace ConsoleApp_04_RangeBasedSwitch
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter score: ");

            string score = Console.ReadLine();

            Console.WriteLine("Your grade is: " + Grade.GetGrade(Convert.ToInt32(score)));

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
