namespace ConsoleApp_05_OperatorOverloadingCar
{
    class Car
    {
        private string _make;
        private string _model;
        private string _colour;
        private double _price;
        private string _registeredKeeper;

        public Car()
        {

        }

        public Car(string carMake, string carModel, string carColour, double carPrice, string keeper)
        {
            this._make = carMake;
            this._model = carModel;
            this._colour = carColour;
            this._price = carPrice;
            this._registeredKeeper = keeper;
        }

        public string Make
        {
            get { return this._make; }
            set { this._make = value; }
        }

        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        public string Colour
        {
            get { return this._colour; }
            set { this._colour = value; }
        }

        public double Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        public string RegisteredKeeper
        {
            get { return this._registeredKeeper; }
            set { this._registeredKeeper = value; }
        }

        public string GetDetails()
        {
            return _make + " " + _model + " " + _colour + " " + _price + " " + _registeredKeeper;
        }

        public static Car operator +(Car car1, Car car2)
        {
            Car newCar = new Car
            {
                Make = car1._make + " and " + car2._make,

                Model = car1._model + " and " + car2._model,

                Colour = car1._colour + " and " + car2._colour,

                Price = car1._price + car2._price,

                RegisteredKeeper = car1._registeredKeeper + " and " + car2._registeredKeeper
            };

            return newCar;
        }
    }
}
