using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_13_MOQ_AddressChanger_MainCode
{
    public class MainframeSystem
    {
        public virtual string GetCustomerAddress(Customer customer)
        {
            return customer.Address;
        }

        public virtual void SetCustomerAddress(Customer customer, string newAddress)
        {
            customer.Address = newAddress;
        }
    }
}
