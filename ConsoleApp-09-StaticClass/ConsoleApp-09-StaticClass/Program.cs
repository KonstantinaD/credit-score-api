using System;

namespace ConsoleApp_09_StaticClass
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("JaguarCars.companyName : " + JaguarCars.companyName);
            Console.WriteLine("JaguarCars.companyRegOffice : " + JaguarCars.companyRegOffice);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
