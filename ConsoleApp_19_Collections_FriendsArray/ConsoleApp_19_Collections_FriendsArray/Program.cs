using System;
using System.Collections.Generic;

namespace ConsoleApp_19_Collections_FriendsArray
{
    class Program
    {
        private static List<string> friends = new List<string>() { "Dimi", "Rolf", "Gena", "Lili", "Neli" };

        public static void Main()
        {
            Console.WriteLine($"The number of friends in the list is: {friends.Count}");

            Console.WriteLine("\nInitial list:");

            ShowValues();


            Console.WriteLine("\nAfter replacing with a new friend's name:");

            friends[4] = "NewFriend";

            ShowValues();


            Console.WriteLine("\nAfter replacing with null:");

            friends[1] = null;

            ShowValues();


            Console.WriteLine("\nAfter sorting:");

            friends.Sort();

            ShowValues();


            Console.WriteLine($"\nThe first person in the list is: {friends[1]}");

            Console.WriteLine($"\nThe last person in the list is: {friends[4]}");


            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        public static void ShowValues ()
        {
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }
        }
    }
}
