using System;
using System.Collections.Generic;

namespace ConsoleApp_19_Collections_LinkedList
{
    class Program
    {
        public static void ShowMyLinkedList(string comment, LinkedList<string> itemListing)
        {
            Console.WriteLine("ShowMyLinkedList LinkedList<string> : ");
            Console.WriteLine("comment: " + comment);

            foreach (string item in itemListing)
                Console.WriteLine("   {0}", item);

            Console.WriteLine();
        }

        static void Main()
        {
            string[] items = { "Bananas", "Milk", "Flour", "Bread", "Sugar", "Oranges", "Apples", "Cheese" };
            LinkedList<string> foodlist = new LinkedList<string>(items);
            try
            {
                ShowMyLinkedList("initial list:-", foodlist);
                var founditem = foodlist.Find("Bananas");
                foodlist.AddAfter(founditem, "Coconut");
                ShowMyLinkedList("add Coconut after Bananas:-", foodlist);
                foodlist.AddFirst("Teabags");
                ShowMyLinkedList("add Teabag to start:-", foodlist);

                //no need to create a new one
                LinkedList<string> foodlist1 = new LinkedList<string>(foodlist);
                foodlist1.RemoveFirst();
                foodlist1.RemoveLast();
                ShowMyLinkedList("removed first and last values:-", foodlist1);
                foodlist1.Remove("Oranges");
                ShowMyLinkedList("removed Oranges:-", foodlist1);
            }
            catch { Console.WriteLine("cannot find value to add to"); }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
