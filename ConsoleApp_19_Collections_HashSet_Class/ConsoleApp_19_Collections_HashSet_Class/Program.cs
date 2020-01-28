using System;
using System.Collections.Generic;

namespace ConsoleApp_19_Collections_HashSet_Class
{
    class Program
    {
        public static void Main()
        {
            HashSet<int> initialSet = new HashSet<int>();

            for (int i = 1; i <= 100; i++)
            {
                initialSet.Add(i);
            }

            Console.WriteLine("The initial set contains: ");
            ShowValues(initialSet);

            HashSet<int> setOfMultiplesOfThree = new HashSet<int>();

            foreach (int i in initialSet)
            {
                if ((i % 3) == 0)
                {
                    setOfMultiplesOfThree.Add(i);
                }
            }

            Console.WriteLine("\nThe set of multiples of 3 contains: ");
            ShowValues(setOfMultiplesOfThree);

            HashSet<int> setOfMultiplesOfFive = new HashSet<int>();

            foreach (int i in initialSet)
            {
                if ((i % 5) == 0)
                {
                    setOfMultiplesOfFive.Add(i);
                }
            }

            Console.WriteLine("\nThe set of multiples of 5 contains: ");
            ShowValues(setOfMultiplesOfFive);

            Console.WriteLine("\nIs the set of multiples of 3 a proper subset of the initial set?: " +
                setOfMultiplesOfThree.IsProperSubsetOf(initialSet));

            Console.WriteLine("\nIs the set of multiples of 5 a proper subset of the initial set?: " +
                setOfMultiplesOfFive.IsProperSubsetOf(initialSet));

            initialSet.ExceptWith(setOfMultiplesOfThree);
            initialSet.ExceptWith(setOfMultiplesOfFive);
            Console.WriteLine("\nThe initial set after removing the multiples of 3 and of 5 contains: ");
            ShowValues(initialSet);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        } 

        private static void ShowValues(HashSet<int> set)
        {
            foreach (int i in set)
            {
                Console.Write("{0}{1}", i, set.ToString().EndsWith(i.ToString()) ? "" : " ");
            }

            Console.WriteLine();
        }
    }
}
