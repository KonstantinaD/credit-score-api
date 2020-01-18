using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_09_ConstructorChainingUsers
{
    class InternalUser : User
    {
        public string EmployeeType { get; set; }
        public int EmployeeId { get; set; }

        public InternalUser(string firstName, string lastName, string employeeType, int employeeId) 
            : base(firstName, lastName)
        {
            EmployeeType = employeeType;
            EmployeeId = employeeId;
        }

        public string GetInternalUserDetails()
        {
            return GetUserDetails() + " " + EmployeeType + " " + EmployeeId;
        }
    }
}
