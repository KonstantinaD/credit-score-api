/*
 * Create/Update a Console Application to send the numbers from 1 to 100 into the FizzBuzz method of the Calculator class and display the result.
The Calculator class should have: 
FizzBuzz() method. This method should return the number passed into it, 
BUT - if the number is a multiple of 3 it is replaced with "FIZZ", 
if it is a multiple of 5 it is replaced by "BUZZ", and
if it is a multiple of both 3 and 5, it is replaced by "FIZZ BUZZ".
 */

using System;

namespace ConsoleApp_04_FizzBuzz
{
    class Calculator
    {
        internal static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZ BUZZ");
                } 
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
