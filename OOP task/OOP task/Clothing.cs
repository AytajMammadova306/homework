using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class Clothing:Product
    {
        public override double GetFinalPrice()
        {
            return Price * 0.80;
        }
    }
}
