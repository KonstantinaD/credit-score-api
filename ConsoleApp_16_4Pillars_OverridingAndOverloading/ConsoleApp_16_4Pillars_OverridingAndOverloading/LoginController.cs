using System;

namespace ConsoleApp_16_4Pillars_OverridingAndOverloading
{
    public class LoginController
    {
        //allowing overriding
        public virtual void Login(string username)
        {
            Console.WriteLine("Logging in with username: " + username);

        }

        //Overloaded
        public void Login(int id)
        {
            Console.WriteLine("Logging in with id: " + id);
        }

        //Overloaded
        public void Login(string email, int reference)
        {
            Console.WriteLine("Logging in with email: " + email + " and reference " + reference);
        }
    }
}
