using System;

namespace ConsoleApp_05_Delegate
{
    class Program
    {
        delegate int squaringDel(int i);
        static void Main()
        {
            Console.Write("Enter a number: ");

            int number = int.Parse(Console.ReadLine());

            squaringDel sqrDelegate = y => y * y;

            int result = sqrDelegate(number);

            Console.WriteLine("The squared number is: {0}", result);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}
