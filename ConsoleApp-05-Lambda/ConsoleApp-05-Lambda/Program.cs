using System;
using System.Linq;

namespace ConsoleApp_05_Lambda
{
    class Program
    {
        static int Square(int i)
        {
            int returnVal = i * i;
            return returnVal;
        }
        static void Main()
        {
            int[] initialArray = { 2, 3, 4, 5 };

            Console.WriteLine("Original Array Of Numbers: ");
            Console.WriteLine(string.Join(" ", initialArray));

            Console.WriteLine("Using Lambda Syntax: ");
            var squaredArray = initialArray.Select(y => y * y);
            Console.WriteLine(string.Join(" ", squaredArray));

            Console.WriteLine("Calling a method: ");
            foreach (int num in initialArray)
            {
                    Console.WriteLine("Number = " + Square(num));
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
