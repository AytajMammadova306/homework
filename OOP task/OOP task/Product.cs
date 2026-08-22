using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class Product
    {
        private string _name;
        private double _price;
        public double Price { get { return _price; } set { if(value < 0) _price = 0; else _price = value; } }
        public string Name { get; set; }
        public virtual double GetFinalPrice()
        {
            return _price;
        }
    }
}
