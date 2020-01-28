using System;

namespace ConsoleApp_19_Collections_OverrideEqualsAndGetHashCode
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            Book book1 = new Book("The Kubernetes Book", "Nigel P.");
            Book book2 = new Book("The Kubernetes Book", "Nigel P.");
            Book book3 = new Book("Docker Deep Dive", "Nigel P.");
            Book book4 = new Book("Docker Deep Dive", "Nigel P.");

            Console.WriteLine($"book1.Equals(book2) = { book1.Equals(book2) }");
            Console.WriteLine($"book1.Equals(book3) = { book1.Equals(book3) }");

            Console.WriteLine($"book3.Equals(book2) = { book3.Equals(book2) }");
            Console.WriteLine($"book3.Equals(book4) = { book3.Equals(book4) }");

            Console.WriteLine($"\nbook1 hash code = { book1.GetHashCode() }");
            Console.WriteLine($"book2 hash code = { book2.GetHashCode() }");
            Console.WriteLine($"book3 hash code = { book3.GetHashCode() }");
            Console.WriteLine($"book4 hash code = { book4.GetHashCode() }");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
