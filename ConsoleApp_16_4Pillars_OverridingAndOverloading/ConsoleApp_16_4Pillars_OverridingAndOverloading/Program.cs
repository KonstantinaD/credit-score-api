using System;

namespace ConsoleApp_16_4Pillars_OverridingAndOverloading
{
    class Program
    {
        static void Main()
        {
            {
                Console.WriteLine("Parent class login methods:");
                LoginController loginController = new LoginController();
                loginController.Login("John.Smith");
                loginController.Login(123);
                loginController.Login("test@email.com", 2);

                Console.WriteLine("\nChild class login method:");
                AdminLoginController adminLoginController = new AdminLoginController();
                adminLoginController.Login("Jane.Doe");

                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
