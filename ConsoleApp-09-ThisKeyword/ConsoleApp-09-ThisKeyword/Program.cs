using System;

namespace ConsoleApp_09_ThisKeyword
{
    class Program
    {
        static void Main()
        {
            User user1 = new User();

            Console.WriteLine("The default details of the user are: " + user1.GetDetails());

            User user2 = new User("Mimi", "Por");

            Console.WriteLine("The custom details of the user are: " + user2.GetDetails());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
