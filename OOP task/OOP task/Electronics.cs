using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class Electronics:Product
    {
        public override double GetFinalPrice()
        {
            return Price * 1.1;
        }
    }
}
