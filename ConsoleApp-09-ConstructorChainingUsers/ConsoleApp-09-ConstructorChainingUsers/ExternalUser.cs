using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_09_ConstructorChainingUsers
{
    class ExternalUser : User 
    {
        public ExternalUser(string firstName, string lastName) : base(firstName, lastName)
        {

        }
    }
}
