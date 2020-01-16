using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_04_Ternary
{
    class Comparison
    {
        public static void Compare(int value1, int value2)
        {
            int result = value1 > value2 ? value1 : value2;

            Console.WriteLine("The bigger number is: " + result.ToString());
        }
    }
}
