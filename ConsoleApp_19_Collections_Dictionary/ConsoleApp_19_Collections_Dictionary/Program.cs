using System;

namespace ConsoleApp_19_Collections_Dictionary
{
    class Program
    {
        static void Main()
        {
            String findPropertyName = "Northumberland Avenue";
            double theOutParamPrice;

            MonopolyProperty.ShowPropertyPrices();
            MonopolyProperty.ShowPropertyPrices(findPropertyName);
            MonopolyProperty.ShowPropertyPrices("Avenue");
            MonopolyProperty.ShowPropertyPrices(findPropertyName, out theOutParamPrice);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
