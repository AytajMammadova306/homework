using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Rectangle
    {
        private int _width;
        private int _height;

        public void SetSize(int width, int height)
        {
            _height = height;
            _width = width;
        }
        public int CalculateArea()
        {
            return _width * _height;
        }
        public void PrintArea()
        {
            Console.WriteLine($"Area of rectangle with width: {_width}, hegith: {_height} is {CalculateArea()}");
        }
    }
}
