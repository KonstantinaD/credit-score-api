using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp_19_Collections_List
{
    class Program
    {
        public static void ShowGalaxies()
        {
            IList<Galaxy> theGalaxies = new List<Galaxy>()
            {
              new Galaxy() { name = "Tadpole", megaLightYears = 400 },
              new Galaxy() { name = "Pinwheel", megaLightYears = 25 },
              new Galaxy() { name = "Milky Way", megaLightYears = 400},
              new Galaxy() { name = "Andromeda", megaLightYears = 3 },
            };

            Console.WriteLine("The initial galaxies: ");

            ShowValues(theGalaxies);

            Galaxy galaxy1 = new Galaxy() { name = "Galli", megaLightYears = 900 };

            theGalaxies.Add(galaxy1);

            Console.WriteLine("\nThe galaxies after addition: ");

            ShowValues(theGalaxies);

            Galaxy galaxy2 = new Galaxy() { name = "GallIns", megaLightYears = 1 };

            theGalaxies.Insert(2, galaxy2);

            Console.WriteLine("\nThe galaxies after inserting: ");

            ShowValues(theGalaxies);

            theGalaxies.Remove(galaxy1);

            Console.WriteLine("\nThe galaxies after removing: ");

            ShowValues(theGalaxies);

            Console.WriteLine("\nContains?: " + theGalaxies.Contains(galaxy2));

            Console.WriteLine("\nIndex of?: " + theGalaxies.IndexOf(galaxy2));

            Galaxy[] newArray = new Galaxy[]
            {
              new Galaxy() { name = "ArrGal", megaLightYears = 600 },
              new Galaxy() { name = "ArrGal1", megaLightYears = 75 },
              new Galaxy() { name = "Milky Arr", megaLightYears = 500},
              new Galaxy() { name = "Milky Arr1", megaLightYears = 50},
              new Galaxy() { name = "Milky Arr2", megaLightYears = 55},
              new Galaxy() { name = "Milky Arr3", megaLightYears = 57}
            };

            theGalaxies.CopyTo(newArray, 1);

            Console.WriteLine("\nThe new array after copying: ");

            ShowValues(newArray);

            theGalaxies[3] = new Galaxy() { name = "SetVal", megaLightYears = 60 };

            Console.WriteLine("\nThe new array after setting a value: ");

            ShowValues(theGalaxies);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        public static void ShowValues(IList<Galaxy> theGalaxies)
        {
            foreach (var galaxy in theGalaxies)
            {
                Console.WriteLine("   name: " + galaxy.name + "  " + galaxy.megaLightYears);
            }
        }

        static void Main()
        {
            ShowGalaxies();
        }
    }
}
