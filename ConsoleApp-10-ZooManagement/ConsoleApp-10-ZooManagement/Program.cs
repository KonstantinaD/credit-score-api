using System;

namespace ConsoleApp_10_ZooManagement
{
    class Program
    {
        static void Main()
        {
            IMover animal1 = new Hamster();
            Console.WriteLine("----");
            Console.WriteLine(animal1.Move());

            Animal pet1 = new Hamster();
            Console.WriteLine("----");
            Console.WriteLine(pet1.Move());
            Console.WriteLine(pet1.Eat());
            Console.WriteLine(pet1.GetDescription());

            Animal animal2 = new RedKangaroo();
            Console.WriteLine("----");
            Console.WriteLine(animal2.Move());
            Console.WriteLine(animal2.Eat());
            Console.WriteLine(animal2.GetDescription());

            Turtle animal3 = new Turtle();
            Console.WriteLine("----");
            Console.WriteLine(animal3.Move());
            Console.WriteLine(animal3.Eat());
            Console.WriteLine(animal3.GetDescription());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
