namespace ConsoleApp_09_BaseKeyword
{
    class Vehicle
    {
        private string _make;
        private double _price;

        internal Vehicle(string vehicleMake, double vehiclePrice)
        {
            this._make = vehicleMake;
            this._price = vehiclePrice;
        }

        internal string GetDetails()
        {
            return _make + " " + _price;
        }
    }
}