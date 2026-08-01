using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private int _year;

        public void SetCar(string brand, string model, int year)
        {
            _brand = brand;
            _model = model;
            _year = year;
        }
        public void PrintCar()
        {
            Console.WriteLine($"Brand: {_brand},\t Model: {_model},\t Year: {_year}");
        }
    }
}
