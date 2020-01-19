using System;

namespace ConsoleApp_10_AbstractClassAndInterface
{
    class Program
    {
        static void Main()
        {
            ExternalUser extUser = new ExternalUser("extUsername", "extPass");

            Console.WriteLine(extUser.login("extUsername", "extPass"));

            InternalUser intUser = new InternalUser("intUsername", "intPass", "1");

            Console.WriteLine(intUser.login("intUsername", "intPass", "1"));

            PermanentStaff perm = new PermanentStaff("permUsername", "permPass", "2");

            Console.WriteLine(perm.login("permUsername", "permPass", "2"));

            TemporaryStaff temp = new TemporaryStaff("tempUsername", "tempPass", "3");

            Console.WriteLine(temp.login("tempUsername", "tempPass", "3"));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
