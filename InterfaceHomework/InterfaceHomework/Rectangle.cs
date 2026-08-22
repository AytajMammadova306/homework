using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    internal class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
