using System;

namespace ConsoleApp_11_Params2
{
    class Program
    {
        public static void ParamsMethod(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();
        }

        static void Main()
        {
            object[] arr = { 1, 2, "Jill", "Tom", 10.26 };

            Console.WriteLine("Calling ParamsMethod() with an array");
            ParamsMethod(arr);
            Console.WriteLine("---");

            Console.WriteLine("Calling ParamsMethod() with comma-separated list of objects");
            ParamsMethod(true, 3, "Red", 12.66, "Osi", false);
            Console.WriteLine("---");

            Console.WriteLine("Calling ParamsMethod() with no arguments");
            ParamsMethod();
            Console.WriteLine("---");

            Console.WriteLine("Press 'Enter' Key to Exit...");
            Console.ReadLine();
        }
    }
}
