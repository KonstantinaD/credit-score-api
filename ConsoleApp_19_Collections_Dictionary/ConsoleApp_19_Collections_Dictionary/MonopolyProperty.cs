using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_19_Collections_Dictionary
{
    class MonopolyProperty
    {
        private static IDictionary<String, Double> monopolyPropertyPriceList;

        public static void SetPropertyPrices()
        {
            monopolyPropertyPriceList = new Dictionary<String, Double>();

            monopolyPropertyPriceList.Add("Old Kent Road", 60.00d);
            monopolyPropertyPriceList.Add("Whitechapel Road", 60.00d);
            monopolyPropertyPriceList.Add("The Angel, Islington", 100.00d);
            monopolyPropertyPriceList.Add("Euston Road", 100.00d);
            monopolyPropertyPriceList.Add("Pentonville Road", 120.00d);
            monopolyPropertyPriceList.Add("Pall Mall", 140.00d);
            monopolyPropertyPriceList.Add("Whitehall", 140.00d);
            monopolyPropertyPriceList.Add("Northumberland Avenue", 160.00d);
            monopolyPropertyPriceList.Add("Bow Street", 180.00d);
            monopolyPropertyPriceList.Add("Great Marlborough Street", 180.00d);
            monopolyPropertyPriceList.Add("King's Cross station", 200.00d);
            monopolyPropertyPriceList.Add("Marylebone station", 200.00d);
            monopolyPropertyPriceList.Add("Vine Street", 200.00d);
            monopolyPropertyPriceList.Add("Fenchurch Street station", 200.00d);
            monopolyPropertyPriceList.Add("Liverpool Street station", 200.00d);
            monopolyPropertyPriceList.Add("Strand", 220.00d);
            monopolyPropertyPriceList.Add("Fleet Street", 220.00d);
            monopolyPropertyPriceList.Add("Trafalgar Square", 240.00d);
            monopolyPropertyPriceList.Add("Leicester Square", 260.00d);
            monopolyPropertyPriceList.Add("Coventry Street", 260.00d);
            monopolyPropertyPriceList.Add("Piccadilly", 280.00d);
            monopolyPropertyPriceList.Add("Regent Street", 300.00d);
            monopolyPropertyPriceList.Add("Oxford Street", 300.00d);
            monopolyPropertyPriceList.Add("Bond Street", 320.00d);
            monopolyPropertyPriceList.Add("Park Lane", 350.00d);
            monopolyPropertyPriceList.Add("Mayfair", 400.00d);
        }

        public static void ShowPropertyPrices()
        {
            SetPropertyPrices();

            Console.WriteLine();
            Console.WriteLine("ShowPropertyPrices - All");
            for (int i = 0; i < monopolyPropertyPriceList.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                    monopolyPropertyPriceList.Keys.ElementAt(i),
                    String.Format("{0:C}", monopolyPropertyPriceList[monopolyPropertyPriceList.Keys.ElementAt(i)])
                    );
            }
        }

        public static void ShowPropertyPrices(String propertyName)
        {
            SetPropertyPrices();

            Console.WriteLine();
            Console.WriteLine("ShowPropertyPrices for - {0}", propertyName);

            // See whether Dictionary contains this string.
            if (monopolyPropertyPriceList.ContainsKey(propertyName))
            {
                double propertyPrice = monopolyPropertyPriceList[propertyName];

                Console.WriteLine("Key: {0}, Value: {1}",
                    propertyName,
                    String.Format("{0:C}", propertyPrice)
                );
            }
            else
            {
                Console.WriteLine("NOT in Dictionary:  {0} ", propertyName);
            }
        }
 
        public static void ShowPropertyPrices(String propertyName, out double thePrice)
        {
            SetPropertyPrices();

            Console.WriteLine();
            Console.WriteLine("ShowPropertyPrices with the" +
                              " Out Param Price for - {0}", propertyName);


            if (monopolyPropertyPriceList.TryGetValue(propertyName, out thePrice))
            {
                double propertyPrice = monopolyPropertyPriceList[propertyName];

                Console.WriteLine("Key: {0}, Value: {1}",
                    propertyName,
                    String.Format("{0:C}", propertyPrice)
                );
            }
            else
            {
                Console.WriteLine("NOT in Dictionary:  {0} ", propertyName);
            }
        }
    }
}

