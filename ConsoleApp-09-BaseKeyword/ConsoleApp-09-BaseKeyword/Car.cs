namespace ConsoleApp_09_BaseKeyword
{
    class Car : Vehicle
    {
        internal Car(string make, double price) : base(make, price)
        {
            /*Calling the base class GetDetails() method - the below is possible to write but not needed, from the child object - car - we can access a parent method
             */
            //base.GetDetails();
        }
    }
}