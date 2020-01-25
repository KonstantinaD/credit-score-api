using ClassLibrary_13_MOQ_AddressChanger_MainCode;
using Moq;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class AddressChangerFunctionalityTest
    {
        [Test]
        public void Test_GetCustomerAddress_ReturnsAddress()
        {
            //arrange
            int id = 1;
            string address = "5 Bar Street, Leeds";
            Customer customer = new Customer(id, address);
            MainframeSystem system = new MainframeSystem();

            //act
            string actualValue = system.GetCustomerAddress(customer);

            //assert
            Assert.That(actualValue, Is.EqualTo(address));
        }

        [Test]
        public void Test_ChangeCustomerAddress_CallsGetCustomerAddress_Once()
        {
            //arrange
            int id = 1;
            string address = "5 Bar Street, Leeds";
            Customer customer = new Customer(id, address);
            AddressChanger changer = new AddressChanger();
            Mock<MainframeSystem> mockSystem = new Mock<MainframeSystem>();

            //act
            changer.ChangeCustomerAddress(customer, mockSystem.Object.GetCustomerAddress(customer),"");

            //assert
            mockSystem.Verify(s => s.GetCustomerAddress(customer), Times.Once);
        }

        [Test]
        public void Test_SetCustomerAddress_SetsNewAddress()
        {
            //arrange
            int id = 1;
            string oldAddress = "5 Bar Street, Leeds";
            string newAddress = "New Address";
            Customer customer = new Customer(id, oldAddress);
            MainframeSystem system = new MainframeSystem();

            //act
            system.SetCustomerAddress(customer, newAddress);

            //assert
            Assert.That(customer.Address, Is.EqualTo(newAddress));
        }

        [Test]
        public void Test_ChangeCustomerAddress_CallsSetCustomerAddress_Once()
        {
            //arrange
            int id = 1;
            string oldAddress = "5 Bar Street, Leeds";
            string newAddress = "New Address";
            Customer customer = new Customer(id, oldAddress);
            AddressChanger changer = new AddressChanger();
            Mock<MainframeSystem> mockSystem = new Mock<MainframeSystem>();
            mockSystem.Object.SetCustomerAddress(customer, newAddress);

            //act
            changer.ChangeCustomerAddress(customer, oldAddress, newAddress);

            //assert
            mockSystem.Verify(s => s.SetCustomerAddress(customer, newAddress), Times.Once);
        }

        [Test]
        public void Test_AuditChangeOfAddress_OutputStringContainsCustomerIdOldAddressAndNewAddress()
        {
            //arrange
            int id = 1;
            string oldAddress = "5 Bar Street, Leeds";
            string newAddress = "New Address";
            Customer customer = new Customer(id, oldAddress);
            AuditingSystem system = new AuditingSystem();

            //act
            string actualValue = system.AuditChangeOfAddress(customer, oldAddress, newAddress);

            //assert
            StringAssert.Contains(customer.Id.ToString(), actualValue);
            StringAssert.Contains(oldAddress, actualValue);
            StringAssert.Contains(newAddress, actualValue);
        }

        [Test]
        public void Test_ChangeCustomerAddress_CallsAuditChangeOfAddress_Once()
        {
            //arrange
            int id = 1;
            string oldAddress = "5 Bar Street, Leeds";
            string newAddress = "New Address";
            Customer customer = new Customer(id, oldAddress);
            AddressChanger changer = new AddressChanger();
            Mock<AuditingSystem> mockSystem = new Mock<AuditingSystem>();
            mockSystem.Object.AuditChangeOfAddress(customer, oldAddress, newAddress);

            //act
            changer.ChangeCustomerAddress(customer, oldAddress, newAddress);

            //assert
            mockSystem.Verify(s => s.AuditChangeOfAddress(customer, oldAddress, newAddress), Times.Once);
        }
    }
}
