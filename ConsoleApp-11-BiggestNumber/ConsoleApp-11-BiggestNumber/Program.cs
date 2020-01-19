using System;

namespace ConsoleApp_11_BiggestNumber
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            Console.WriteLine("Enter the total number of integers");
            count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int biggestNumber = numbers[0];

            for (int j = 1; j < count; j++)
            {
                if (biggestNumber < numbers[j])
                {
                    biggestNumber = numbers[j];
                }
            }
            Console.WriteLine("The biggest number is: " + biggestNumber);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
