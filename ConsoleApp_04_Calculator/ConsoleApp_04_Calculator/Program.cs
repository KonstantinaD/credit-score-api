using System;

namespace ConsoleApp_04_Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter decimal number 1: ");

            string num1 = Console.ReadLine();

            Console.WriteLine("Enter decimal number 2: ");

            string num2 = Console.ReadLine();

            Console.WriteLine("The sum of the numbers is: {0}", Calculator.Add(Convert.ToDouble(num1), Convert.ToDouble(num2)));

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
