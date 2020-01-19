namespace ConsoleApp_10_AbstractClassAndInterface
{
    class PermanentStaff : InternalUser
    {
        public PermanentStaff(string username, string password, string employeeId)
            : base(username, password, employeeId)
        {

        }
    }
}
