using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    internal class Circle:IShape
    {
        public int Radius {  get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
