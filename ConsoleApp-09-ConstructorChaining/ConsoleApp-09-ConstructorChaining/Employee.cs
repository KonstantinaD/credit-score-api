namespace ConsoleApp_09_ConstructorChaining
{
    public class Employee
    {
        string _employeeType = "";
        string _id = "";
        string _firstName = "";
        string _lastName = "";

        public Employee(string id)
        : this(id, "", "") { }

        public Employee(string id, string firstName)
        : this(id, firstName, "") { }

        public Employee(string id, string firstName, string lastName)
        {    
            _employeeType = "Perm and temp";

            _id = id;
            _firstName = firstName;
            _lastName = lastName;
        }

        public string GetDetails()
        {
            return _employeeType + " " + _id + " " + _firstName + " " + _lastName;
        }
    }
}
