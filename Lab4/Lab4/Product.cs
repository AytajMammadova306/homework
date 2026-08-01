using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _quantity;

        public void SetProduct(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }
        public double CalculateTotalPrice()
        {
            return _price * _quantity;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{_quantity} of product {_name} at {_price:C2} will cost {CalculateTotalPrice()}");
        }
    }
}
