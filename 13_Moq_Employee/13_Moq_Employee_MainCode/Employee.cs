namespace _13_Moq_Employee_MainCode
{
    public class Employee
    {
        public bool AddNewEmployee(MyEmail email)
        {
            // Code to Add the New Employee details to the database and send email
            return email.SendEmail();
        }
    }
}
