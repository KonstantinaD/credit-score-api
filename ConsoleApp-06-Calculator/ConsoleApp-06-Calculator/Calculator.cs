using System;

namespace ConsoleApp_06_Calculator
{
    class Calculator
    {
        internal static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        internal static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        internal static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        internal static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Cannot divide by 0");
            }

            return num1 / num2;
        }
    }
}
