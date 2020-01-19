using System;
using System.Linq;

namespace ConsoleApp_11_Params_BiggestNumber
{
    class Program
    {
        public static int FindBiggestNumber(params int[] arr)
        { 
            return arr.Max();
        }

        static void Main()
        {
            int[] intArray = { 2, 4, 3, 8, 10, 0, 5 };

            Console.WriteLine("The biggest number giving an array to the method is: " + FindBiggestNumber(intArray));

            Console.WriteLine();

            Console.WriteLine("The biggest number giving a a comma-separated list to the method is: " + FindBiggestNumber(5, 2, 8, 0, 1, 12, 7));

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
