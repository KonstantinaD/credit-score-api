using System;

namespace ConsoleApp_16_4Pillars_OverridingAndOverloading
{
    class AdminLoginController : LoginController
    {
        //overriden
        public override void Login(string username)
        {
            Console.WriteLine("Logging in admin with username: " + username);
        }
    }
}
