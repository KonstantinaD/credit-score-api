namespace ConsoleApp_10_AbstractClassAndInterface
{
    class TemporaryStaff : InternalUser
    {
        public TemporaryStaff(string username, string password, string employeeId)
            : base(username, password, employeeId)
        {

        }
    }
}
