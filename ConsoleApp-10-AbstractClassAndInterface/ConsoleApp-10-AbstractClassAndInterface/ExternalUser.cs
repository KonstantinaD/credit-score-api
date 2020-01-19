namespace ConsoleApp_10_AbstractClassAndInterface
{
    class ExternalUser : User
    {
        public ExternalUser(string username, string password, string employeeId = null) 
            : base(username, password, employeeId)
        {

        }

        public override string login(string username, string password, string employeeId = null)
        {
            return $"Hi {username}. Your password is: {password}.";
        } 
    }
}
