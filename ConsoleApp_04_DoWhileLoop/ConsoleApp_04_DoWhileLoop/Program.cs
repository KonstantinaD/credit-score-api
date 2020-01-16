using System;

namespace ConsoleApp_04_DoWhileLoop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");

            string number = Console.ReadLine();

            Loop.Execute(Convert.ToInt32(number));

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
