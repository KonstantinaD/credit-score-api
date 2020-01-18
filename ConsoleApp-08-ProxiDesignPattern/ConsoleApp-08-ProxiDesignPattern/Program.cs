using System;

namespace ConsoleApp_08_ProxiDesignPattern
{
    class Program
    {
        static void Main()
        { 
            MathProxy proxy = new MathProxy();

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));

            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));

            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));

            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}