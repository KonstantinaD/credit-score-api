using _13_Moq_Employee_MainCode;
using Moq;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class EmployeeTest
    {
        [Test]
        public void Test_AddNewEmployee_AddNew_ReturnTrueWhenAdded()
        {
            //arrange
            // Create the mock object 
            Mock<MyEmail> emailObj = new Mock<MyEmail>();
            // Specify which method to mock - skip over and return your specified outcome 
            emailObj.Setup(em => em.SendEmail()).Returns(true);

            //act  
            Employee emp = new Employee();
            bool isAdded = emp.AddNewEmployee(emailObj.Object);

            //assert
            Assert.AreEqual(isAdded, true);
        }

        [Test]
        public void Test_AddNewEmployee_AddNew_ReturnFalseWhenFailureToAdd()
        {
            //arrange
            Mock<MyEmail> emailObj = new Mock<MyEmail>();
            emailObj.Setup(em => em.SendEmail()).Returns(false);

            //act  
            Employee emp = new Employee();
            bool isAdded = emp.AddNewEmployee(emailObj.Object);

            //assert
            Assert.AreEqual(isAdded, false);
        }
    }
}
