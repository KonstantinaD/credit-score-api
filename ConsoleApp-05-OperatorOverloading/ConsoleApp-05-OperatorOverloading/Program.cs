using System;

namespace ConsoleApp_05_OperatorOverloading
{
    class Program
    {
        static void Main()
        {
            Book bookC = new Book("Microsoft Visual C#", "John Sharp", 150);
            Book bookJava = new Book("Java 101", "Shara Sharp", 200);
            Book newBook = new Book();

            //displaying the Books 
            Console.WriteLine("bookC : {0}", bookC.ToString());
            Console.WriteLine("bookJava : {0}", bookJava.ToString());

            newBook = bookC + bookJava;
            Console.WriteLine("newBook: {0}", newBook.ToString());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
