using System;

namespace ConsoleApp_09_BaseKeyword
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter make: ");
            string make = Console.ReadLine();

            Console.WriteLine("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            Car car = new Car(make, price);

            Console.WriteLine("The car details are: " + car.GetDetails());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}