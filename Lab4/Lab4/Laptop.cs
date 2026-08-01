using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Laptop
    {
        private string _brand;
        private int _ram;
        private double _price;

        public void SetLaptop(string brand, int ram, double price)
        {
            _brand = brand;
            _ram = ram;
            _price = price;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Laptop {_brand} with {_ram}GB RAM costs {_price}");
        }
    }
}
