using System;

namespace ConsoleApp_11_Casting
{
    class Program
    {
        static void Main()
        {
            int i = 23;
            double d = 15.12;

            //automatic type conversion 
            long l = i;
            float f = l;
            float fl = i;

            //explicit type casting
            //returns the whole number part of the double
            int doubleToInt = (int)d;

            Console.WriteLine("Int value " + i);
            Console.WriteLine("Long value from int " + l);
            Console.WriteLine("Float value from long " + f);
            Console.WriteLine("Float value from int " + fl);
            Console.WriteLine("Int value from double " + doubleToInt);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
