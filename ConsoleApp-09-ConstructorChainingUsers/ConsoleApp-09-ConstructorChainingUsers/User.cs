using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_09_ConstructorChainingUsers
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public user(string firstname, string lastname)
        {
            firstname = firstname;
            lastname = lastname;
        }

        public string GetUserDetails()
        {
            return FirstName + " " + LastName;
        }
    }
}
