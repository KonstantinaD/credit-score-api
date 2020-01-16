using System;

/*Create a Console Application to create three car objects and display the details by call GetDetails method of the Car class.
Your Car class should have: 
private fields: _make, _model, _colour and _price
public properties with accessor methods
GetDetails() method to return a string of the car fields.
*/
namespace ConsoleApp_04_01_ThreeCarObjects
{
    public class Car
    {
        private string _make;
        private string _model;
        private string _colour;
        private double _price;

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

        public Car(string make, string model, string colour, double price)
        {
            this._make = make;
            this._model = model;
            this._colour = colour;
            this._price = price;
        }

        public string GetDetails()
        {
            return Make + " " + Model + " " + Colour + " " + Price;
        }
    }
}
