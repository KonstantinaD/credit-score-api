using System;

namespace ConsoleApp_11_Parse
{
    class Program
    {
        static void Main()
        {
            string a = "123";
            int c = int.Parse(a);
            Console.WriteLine("Parse string to integer: " + c);
            Console.WriteLine("The type is: " + c.GetType().ToString());

            Console.WriteLine();

            string d = "xyz";
            int e = 10;
            int f = 20;
            bool g = int.TryParse(a, out e);
            Console.WriteLine("Parse valid string to integer - succeeded?: " + g);

            bool h = int.TryParse(d, out f);
            Console.WriteLine("Parse invalid string to integer - succeeded?: " + h);

            /*FAILS - System.FormatException: 'Input string was not in a correct format.' - can't turn xyz into integer
             */
            //int i = int.Parse(d);

            Console.WriteLine();

            string j = "123.45";
            double k = double.Parse(j);
            Console.WriteLine("Parse string to double: " + k);
            Console.WriteLine("The type is: " + k.GetType().ToString());

            Console.WriteLine();

            decimal m = decimal.Parse(j);
            Console.WriteLine("Parse string to decimal: " + m);
            Console.WriteLine("The type is: " + m.GetType().ToString());

            Console.WriteLine();

            bool n = bool.Parse("true");
            Console.WriteLine("Parse string \"true\" to boolean - result:  " + n);
            Console.WriteLine("The type is: " + n.GetType().ToString());

            Console.WriteLine();

            bool p = bool.Parse("false");
            Console.WriteLine("Parse string \"false\" to boolean - result:  " + p);

            /*FAILS - System.FormatException: 'String 'tra' was not recognized as a valid Boolean.' - it will accept as an argument only a valid boolean - "true"/"false"
             */
            //bool t = bool.Parse("tra");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
