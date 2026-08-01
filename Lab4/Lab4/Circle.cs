using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Circle
    {
        private int _radius;

        public void SetRadius(int radius)
        {
            _radius = radius;
        }
        public int CalculateDiameter()
        {
            return _radius * 2;
        }
        public void PrintDiameter()
        {
            Console.WriteLine($"radiusu {_radius} olan cevrenin diameteri: {CalculateDiameter()}");
        }
    }
}
