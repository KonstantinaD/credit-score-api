using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_09_ConstructorChainingUsers
{
    class PermanentStaff : InternalUser
    {
        public double Salary { get; set; }

        public PermanentStaff(string firstName, string lastName, string employeeType, int employeeId, double salary) : base(firstName, lastName, employeeType, employeeId)
        {
            Salary = salary;
        }

        public string GetPermanentStaffDetails()
        {
            return GetInternalUserDetails() + " " + Salary;
        }
    }
}
