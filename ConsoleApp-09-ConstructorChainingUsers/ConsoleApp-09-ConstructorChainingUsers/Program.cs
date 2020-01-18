using System;

namespace ConsoleApp_09_ConstructorChainingUsers
{
    class Program
    {
        static void Main()
        {
            User user = new User("UserFirst", "UserLast");

            Console.WriteLine("The details of a user are: " + user.GetUserDetails());

            InternalUser intUser = new InternalUser("IntFirst", "IntLast", "internal user", 1);

            Console.WriteLine("The details of an internal user are: " + intUser.GetInternalUserDetails());

            ExternalUser extUset = new ExternalUser("ExtFirst", "ExtLast");

            Console.WriteLine("The details of an extermal user are: " + extUset.GetUserDetails());

            PermanentStaff perm = new PermanentStaff("PermFirst", "PermLast", "permanent staff", 2, 1000.50);

            Console.WriteLine("The details of a permanent staff member are: " + perm.GetPermanentStaffDetails());

            TemporaryStaff temp = new TemporaryStaff("TempFirst", "TempLast", "temporary staff", 3);

            Console.WriteLine("The details of a temporary staff member are: " + temp.GetInternalUserDetails());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
