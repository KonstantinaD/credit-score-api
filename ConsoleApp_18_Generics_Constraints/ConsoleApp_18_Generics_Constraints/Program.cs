using System;
using System.Text;

namespace ConsoleApp_18_Generics_Constraints
{
    class Program
    {
        public static void EqualsTest<T>(T s, T t) where T : class
        {
            System.Console.WriteLine(s.Equals(t));
        }

        static void Main()
        {
            string s1 = "target";
            StringBuilder sb = new StringBuilder("target");
            string s2 = sb.ToString();
            EqualsTest<string>(s1, s2);

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
