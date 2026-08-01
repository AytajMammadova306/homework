using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class MobilePhone
    {
        private string _brand;
        private int _batter;
        public void Charge()
        {
            if (_batter + 10 > 100) Console.WriteLine("Charged enough");
            else _batter += 10;
        }
        public void UsePhone()
        {
            if (_batter - 10 <= 0) Console.WriteLine("You cant use your phone");
            else _batter -= 10;
        }
        public void PrintBattery()
        {
            Console.WriteLine($"Your Phone {_brand} is now {_batter}");
        }
    }
}
