using System;

namespace ConsoleApp_18_Generics
{
    class Program
    {
        static void Main()
        {
            var returnedIntegerList = new GenericList<int>().CreateList(5);
            
            Console.WriteLine("Integer list:");
            for (int i = 0; i < returnedIntegerList.Count; i++)
            {
                Console.WriteLine(returnedIntegerList[i]);
            }

            var returnedDecimalList = new GenericList<decimal>().CreateList(12.56m);
            Console.WriteLine("\nDecimal list:");
            for (int i = 0; i < returnedDecimalList.Count; i++)
            {
                Console.WriteLine(returnedDecimalList[i]);
            }

            var returnedStringList = new GenericList<string>().CreateList("sample");
            Console.WriteLine("\nString list:");
            for (int i = 0; i < returnedStringList.Count; i++)
            {
                Console.WriteLine(returnedStringList[i]);
            }   

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
