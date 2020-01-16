using System;

namespace ConsoleApp_05_FuncDelegate
{
    class Program
    {
        static Func<int, bool> isEqual = num => num == 5;
        static void Main()
        {
            Console.WriteLine("Enter number: ");

            int num = int.Parse(Console.ReadLine());

            bool result = isEqual(num);

            Console.WriteLine("The number is equal to 5: {0}", result);

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
