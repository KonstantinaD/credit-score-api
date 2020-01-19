using System;

namespace ConsoleApp_11_Params
{
    class Program
    {
        public static void ParamsMethod(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[] arr = new int[] { 2, 5, 1, 6, 8, 3 };
            ParamsMethod(arr);
            Console.WriteLine("\nPress Any Key to Exit...");
            Console.ReadKey();
        }
    }
}
