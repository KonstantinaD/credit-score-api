using System;

namespace ConsoleApp_04_Ternary
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter first number: ");

            string value1 = Console.ReadLine();

            Console.WriteLine("Enter second number: ");

            string value2 = Console.ReadLine();

            Comparison.Compare(Convert.ToInt32(value1), Convert.ToInt32(value2));

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
