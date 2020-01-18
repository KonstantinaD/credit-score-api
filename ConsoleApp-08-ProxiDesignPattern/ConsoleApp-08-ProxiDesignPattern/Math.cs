using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_08_ProxiDesignPattern
{
    //The 'Real Subject' class
    class Math : IMath
    {
            public double Add(double x, double y) { return x + y; }

            public double Sub(double x, double y) { return x - y; }

            public double Mul(double x, double y) { return x * y; }

            public double Div(double x, double y) { return x / y; }
    }
}
