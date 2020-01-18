using System;

namespace ConsoleApp_09_ConstructorChaining
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee("1");

            Console.WriteLine("The details of employee 1 are: " + employee1.GetDetails());

            Employee employee2 = new Employee("2", "Nadia");

            Console.WriteLine("The details of employee 2 are: " + employee2.GetDetails());

            Employee employee3 = new Employee("3", "George", "Mar");

            Console.WriteLine("The details of employee 3 are: " + employee3.GetDetails());

            TemporaryStaff temp = new TemporaryStaff("temp1", "Tempy");

            Console.WriteLine("The details of temp employee 1 are: " + temp.GetDetails());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
