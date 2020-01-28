using System;
using System.Collections.Generic;

namespace ConsoleApp_19_Collections_HashSet
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            HashSet<int> tempHashSetSet = new HashSet<int>();

            Console.WriteLine("Attempt to insert elements (some duplicate) in HashSet:");
            for (int i = 1; i < 5; i++)
            {
                counter++;
                tempHashSetSet.Add(i * 3);
                Console.WriteLine("Counter - {0}:    {1}", counter, i * 3);
            }

            for (int i = 1; i < 5; i++)
            {
                counter++;
                tempHashSetSet.Add(2 * i + 1);
                Console.WriteLine("Counter - {0}:    {1}", counter, 2 * i + 1);
            }

            Console.WriteLine();
            Console.WriteLine("Displaying the actual elements in the HashSet:");
            // Displaying the actual elements in the HashSet
            counter = 0;
            foreach (int i in tempHashSetSet)
            {
                counter++;
                Console.WriteLine("contains unique elements only: element number {0}:    {1}", counter, i);
            }

            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
