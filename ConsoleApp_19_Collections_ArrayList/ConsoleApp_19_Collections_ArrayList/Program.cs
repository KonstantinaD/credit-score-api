using System;
using System.Collections;

namespace ConsoleApp_19_Collections_ArrayList
{
    class Program
    {
        public static void ShowSortedList()
        {
            ArrayList shoppingList = new ArrayList();
            ArrayList sortedList = new ArrayList();

            shoppingList.Add("Banana");
            shoppingList.Add("Milk");
            shoppingList.Add("Bread");
            shoppingList.Add("Apples");
            shoppingList.Add("Oranges");

            //we can just Sort() shoppingList
            for (int i = 0; i < shoppingList.Count; i++)
            { sortedList.Add(shoppingList[i]); }

            //sorts by the natural order - alphabetically in this case
            sortedList.Sort();
            Console.WriteLine("sortedList: ");

            foreach (string item in shoppingList)
            { Console.WriteLine("   {0}", item); }
            Console.WriteLine();
        }

        static void Main()
        {
            ShowSortedList();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
