using System;
using System.Collections.Generic;

namespace ConsoleApp_16_4Pillars_Dictionary_Monopoly
{
    class Program
    {
        public static decimal getMonopolyPropertyPrice(string propertyName)
        {
            decimal retVal = 0.0m;

            Dictionary<string, decimal> monopolyPropertyPriceList = new Dictionary<string, decimal>();
            monopolyPropertyPriceList.Add("Old Kent Road", 60.00m);
            monopolyPropertyPriceList.Add("Whitechapel Road", 60.00m);
            monopolyPropertyPriceList.Add("The Angel, Islington", 100.00m);
            monopolyPropertyPriceList.Add("Euston Road", 100.00m);
            monopolyPropertyPriceList.Add("Pentonville Road", 120.00m);
            monopolyPropertyPriceList.Add("Pall Mall", 140.00m);
            monopolyPropertyPriceList.Add("Whitehall", 140.00m);
            monopolyPropertyPriceList.Add("Northumberland Avenue", 160.00m);
            monopolyPropertyPriceList.Add("Bow Street", 180.00m);
            monopolyPropertyPriceList.Add("Great Marlborough Street", 180.00m);
            monopolyPropertyPriceList.Add("Marylebone station", 200.00m);
            monopolyPropertyPriceList.Add("Vine Street", 200.00m);
            monopolyPropertyPriceList.Add("Strand", 220.00m);
            monopolyPropertyPriceList.Add("Fleet Street", 220.00m);
            monopolyPropertyPriceList.Add("Trafalgar Square", 240.00m);
            monopolyPropertyPriceList.Add("Leicester Square", 260.00m);
            monopolyPropertyPriceList.Add("Coventry Street", 260.00m);
            monopolyPropertyPriceList.Add("Piccadilly", 280.00m);
            monopolyPropertyPriceList.Add("Regent Street", 300.00m);
            monopolyPropertyPriceList.Add("Oxford Street", 300.00m);
            monopolyPropertyPriceList.Add("Bond Street", 320.00m);
            monopolyPropertyPriceList.Add("Park Lane", 350.00m);
            monopolyPropertyPriceList.Add("Mayfair", 400.00m);

            if (monopolyPropertyPriceList.TryGetValue(propertyName, out retVal))
            {
                return retVal;
            }

            return retVal;
        }

        static void Main()
        {
            decimal result1 = Program.getMonopolyPropertyPrice("");

            Console.WriteLine("The result for a non-existing property is: {0}", result1);

            decimal result2 = Program.getMonopolyPropertyPrice("Regent Street");

            Console.WriteLine("The result for an existing property is: {0}", result2);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}