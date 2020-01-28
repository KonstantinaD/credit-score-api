using System;
using System.Collections.Generic;

namespace ConsoleApp_19_Collections_Stack
{
    class Program
    {
        static void Main()
        {
            ShowMyStack();
        }

        public static void ShowMyStack()
        {
            Console.WriteLine();
            Stack<string> st = new Stack<string>();
            st.Push("e"); st.Push("c"); st.Push("a"); st.Push("r");

            Console.WriteLine("Current stack: ");
            foreach (string i in st)
                Console.Write(i + " ");
            Console.WriteLine();

            st.Push("G");

            Console.WriteLine("\nThe next poppable(to-be-removed) value in stack: {0}", st.Peek());
            Console.WriteLine("\nCurrent stack: ");

            foreach (string i in st) { Console.Write(i + " "); }
            Console.WriteLine();

            Console.WriteLine("\nRemoving values ");
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());

            Console.WriteLine();
            Console.WriteLine("Current stack: ");

            foreach (string i in st) { Console.Write(i + " "); }
            Console.WriteLine();

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
