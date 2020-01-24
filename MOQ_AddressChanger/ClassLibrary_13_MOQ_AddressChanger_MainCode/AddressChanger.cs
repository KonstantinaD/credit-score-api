namespace ClassLibrary_13_MOQ_AddressChanger_MainCode
{
    public class AddressChanger
    {
        MainframeSystem mainframe = new MainframeSystem();

        AuditingSystem audit = new AuditingSystem();

        public void ChangeCustomerAddress(Customer customer, string oldAddress, string newAddress)
        {
            mainframe.GetCustomerAddress(customer);

            mainframe.SetCustomerAddress(customer, newAddress);

            audit.AuditChangeOfAddress(customer, oldAddress, newAddress);
        }
    }
}
