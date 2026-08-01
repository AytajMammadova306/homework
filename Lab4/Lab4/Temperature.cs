using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Temperature
    {
        public double _celsius;

        public void SetTemperature(double celsius)
        {
            _celsius = celsius;
        }
        public double ToFahrenheit()
        {
            return _celsius * 9 / 5 + 32;
        }
        public void PrintTemperature()
        {
            Console.WriteLine($"Temperature {_celsius} is {ToFahrenheit()} in Fahrenheit");
        }
    }
}
