namespace ClassLibrary_13_MOQ_AddressChanger_MainCode
{
    public class Customer
    {
        public int Id { get; set; }
        public string Address { get; set; }


        public Customer(int id, string address)
        {
            Id = id;
            Address = address;
        }
    }
}
