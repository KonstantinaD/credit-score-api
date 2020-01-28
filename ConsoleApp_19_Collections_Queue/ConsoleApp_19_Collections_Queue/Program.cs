using System;
using System.Collections.Generic;

namespace ConsoleApp_19_Collections_Queue
{
    class Program
    {
        static void Main()
        {
            Queue<string> myItems = new Queue<string>();
            myItems.Enqueue("Lemon");
            myItems.Enqueue("Apples");
            myItems.Enqueue("Biscuits");
            myItems.Enqueue("Soap");

            ShowMyQueue("enqueued items :-", myItems);

            var nextItem = myItems.Peek();
            Console.WriteLine("next item to dequeue:- " + nextItem + "\n");
            myItems.Dequeue();
            ShowMyQueue("items after dequeuing " + nextItem + " :- ", myItems);

            bool doesContain = myItems.Contains("Apples");
            Console.WriteLine("Contains Apples?: " + doesContain + "\n");

            myItems.Clear();
            ShowMyQueue("items after queue cleared:- ", myItems);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void ShowMyQueue(string comment, Queue<string> qitem)
        {
            Console.WriteLine("ShowMyQueue Queue<string> : ");
            Console.WriteLine("comment: " + comment);

            foreach (string item in qitem)
            {
                Console.WriteLine("   {0}", item);
            }
            Console.WriteLine();
        }
    }
}
