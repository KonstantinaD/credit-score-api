using System;
using System.Diagnostics;

namespace ConsoleApp_11_Assert
{
    class Program
    {
        static int IntegerDivide(int dividend, int divisor)
        {
            Debug.Assert(divisor != 0, "Cannot divide by 0");
            return (dividend / divisor);
        }

        static void Main()
        {
            Console.WriteLine("Enter a dividend: ");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            Console.WriteLine("The result is: " + IntegerDivide(dividend, divisor));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
