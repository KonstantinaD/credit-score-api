using System;

namespace ConsoleApp_04_CSharpSyntax
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter score: ");

            var score = Console.ReadLine();

            Console.WriteLine("Grade is " + GetGrade.GetGrading(Convert.ToInt32(score)));

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
