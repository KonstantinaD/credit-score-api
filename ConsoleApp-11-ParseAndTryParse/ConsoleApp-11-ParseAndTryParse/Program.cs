using System;

namespace ConsoleApp_11_ParseAndTryParse
{
    class Program
    {
        static void Main()
        {
            string validString = "False";
            string invalidString = "boo";

            bool result1 = bool.Parse(validString);
            Console.WriteLine("The result of parsing a valid string (\"False\") to boolean is: " + result1);

            bool result2 = bool.TryParse(invalidString, out bool typeToBeConvertedInto);
            Console.WriteLine("\nParsing an invalid string to boolean succeeded?: " + result2);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
