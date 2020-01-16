using System;

namespace ConsoleApp_05_FuncDelegate2
{
    class Program
    {
        static public bool CheckValue(int value)
        {
            return value + 5 == 10;
        }

        static Func<int, bool> value = num => num + 5 == 10;
        static void Main()
        {
            Console.WriteLine("Enter number: ");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("The result of the check using the method is: " + CheckValue(num));

            Console.WriteLine();

            Console.WriteLine("The result of the check using Func delegate is: " + value.Invoke(num));

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
