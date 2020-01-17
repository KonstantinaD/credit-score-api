using System;

namespace ConsoleApp_06_Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number 1: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("The result of the Add() method is: " + Calculator.Add(number1, number2));
            Console.WriteLine("The result of the Subtract() method is: " + Calculator.Subtract(number1, number2));
            Console.WriteLine("The result of the Multiply() method is: " + Calculator.Multiply(number1, number2));
            Console.WriteLine("The result of the Divide() method is: " + Calculator.Divide(number1, number2));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
