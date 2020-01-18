using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_09_ConstructorChainingUsers
{
    class TemporaryStaff : InternalUser
    {
        public TemporaryStaff(string firstName, string lastName, string employeeType, int employeeId)
            : base(firstName, lastName, employeeType, employeeId)
        {

        }
    }
}
