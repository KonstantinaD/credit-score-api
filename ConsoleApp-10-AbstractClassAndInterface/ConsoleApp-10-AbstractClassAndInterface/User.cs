namespace ConsoleApp_10_AbstractClassAndInterface
{
    abstract class User : IUser
    {
        protected string Username { get; set; }

        protected string Password { get; set; }

        protected string EmployeeId { get; set; }

        protected User(string username, string password, string employeeId)
        {
            Username = username;
            Password = password;
            EmployeeId = employeeId;
        }

        public abstract string login(string username, string password, string employeeId);
    }
}
