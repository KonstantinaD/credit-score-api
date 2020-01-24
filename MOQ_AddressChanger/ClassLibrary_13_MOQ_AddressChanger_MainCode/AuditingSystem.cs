namespace ClassLibrary_13_MOQ_AddressChanger_MainCode
{
    public class AuditingSystem
    {
        public virtual string AuditChangeOfAddress(Customer customer, string oldAddress, string newAddress)
        {
            return "Details of change of address are: customer id: " + customer.Id + ", old address: " + oldAddress + ", new address: " + newAddress;
        }
    }
}
