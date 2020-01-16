using System;

namespace ConsoleApp_04_ForEachLoop
{
    class Loop
    {
       internal static void Execute()
        {
            int[] numbers = new int[3];
            numbers[0] = 3;
            numbers[1] = 5;
            numbers[2] = 8;

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
