using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class Motorcycle:Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"{Speed} km/saat sürətlə motosiklet idarə olunur.");
        }
    }
}
