using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_09_ConstructorChainingUsers
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetUserDetails()
        {
            return FirstName + " " + LastName;
        }
    }
}
