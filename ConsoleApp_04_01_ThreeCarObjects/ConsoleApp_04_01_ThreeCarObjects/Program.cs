using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_04_01_ThreeCarObjects
{
    public class Program

    {
        public static void Main()
        {

            Car car1 = new Car("Honda", "Accord", "red", 12000.99);

            Car car2 = new Car("Toyota", "Bari", "blue", 10000);

            Car car3 = new Car("Ferrari", "Monde", "white", 230500.50);

            Console.WriteLine("Car 1 details are: " + car1.GetDetails());

            Console.WriteLine("Car 2 details are: " + car2.GetDetails());

            Console.WriteLine("Car 3 details are: " + car3.GetDetails());

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }
    }
}
