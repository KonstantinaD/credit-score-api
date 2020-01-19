namespace ConsoleApp_10_AbstractClassAndInterface
{
    class InternalUser : User
    {
        public InternalUser(string username, string password, string employeeId) 
            : base(username, password, employeeId)
        {

        }

        public override string login(string username, string password, string employeeId)
        {
            return $"Hi {employeeId}. Your username and password are: {username} and {password}";
        }
    }
}
