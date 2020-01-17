using System;

namespace ConsoleApp_05_OperatorOverloadingCar
{
    class Program
    {
        static void Main()
        {
            Car car1 = new Car("Toyota", "Corolla", "red", 1000, "Oscar");
            Car car2 = new Car("Ford", "Mondeo", "blue", 2000, "Benny");
            Car car3 = new Car("Honda", "Yaris", "white", 3000, "Maria");
            Car car4 = new Car("Ferrari", "Roche", "silver", 4000, "Natalia");
            Car car5 = new Car("Mitsubishi", "Japa", "black", 5000, "Orka");
            Car car6 = new Car("VW", "Passat", "gold", 6000, "Teddy");

            Console.WriteLine("The details of car 1 are: " + car1.GetDetails());
            Console.WriteLine("The details of car 2 are: " + car2.GetDetails());
            Console.WriteLine("The details of car 3 are: " + car3.GetDetails());
            Console.WriteLine("The details of car 4 are: " + car4.GetDetails());
            Console.WriteLine("The details of car 5 are: " + car5.GetDetails());
            Console.WriteLine("The details of car 6 are: " + car6.GetDetails());

            Console.WriteLine();

            Car newCarTwoCarsAdded1 = car1 + car2;
            Console.WriteLine("The details of the new car (made up of the first 2 cars) are (note that the price is a sum of the prices of the added cars): " + newCarTwoCarsAdded1.GetDetails());

            Console.WriteLine();

            Car newCarTwoCarsAdded2 = car3 + car4;
            Console.WriteLine("The details of the new car (made up of the second 2 cars) are (note that the price is a sum of the prices of the added cars): " + newCarTwoCarsAdded2.GetDetails());

            Console.WriteLine();

            Car newCarFourCarsAdded = newCarTwoCarsAdded1 + newCarTwoCarsAdded2;

            Car newCarFiveCarsAdded = newCarFourCarsAdded + car5;
            Console.WriteLine("The details of the new car (made up of the first 5 cars) are (note that the price is a sum of the prices of the added cars): " + newCarFiveCarsAdded.GetDetails());

            Console.WriteLine("Press any key to exit.");

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
