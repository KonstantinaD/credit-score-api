using System;

namespace ConsoleApp_19_CollectionApp
{
    class Program
    {
        static void Main()
        {
            ExampleOfArrays.ShowSingleDimensional();

            ExampleOfArrays.ShowTwoDimensional();

            ExampleOfArrays.ShowThreeDimensional();

            ExampleOfArrays.ShowJaggedArray();

            Console.WriteLine();
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
