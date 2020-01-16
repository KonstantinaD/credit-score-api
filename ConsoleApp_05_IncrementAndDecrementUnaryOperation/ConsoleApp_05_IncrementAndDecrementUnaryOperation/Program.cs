using System;

namespace ConsoleApp_05_IncrementAndDecrementUnaryOperation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");

            string number = Console.ReadLine();

            Console.WriteLine("The result of the prefix increment (++number) is: {0}", IncrementAndDecrement.DoPrefixIncrement(Convert.ToInt32(number)));

            Console.WriteLine("The result of the postfix increment (number++) is: {0}", IncrementAndDecrement.DoPostfixIncrement(Convert.ToInt32(number)));

            Console.WriteLine("The result of the prefix decrement (--number) is: {0}", IncrementAndDecrement.DoPrefixDecrement(Convert.ToInt32(number)));

            Console.WriteLine("The result of the postfix increment (number--) is: {0}", IncrementAndDecrement.DoPostfixDecrement(Convert.ToInt32(number)));

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
