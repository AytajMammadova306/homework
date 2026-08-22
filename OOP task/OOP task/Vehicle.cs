using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class Vehicle
    {
        private double _speed;
        public double Speed
        {
            set { if (value < 0) _speed = 0; else _speed = value; }
            get { return _speed; }
        }
        public virtual void Drive() { }
    }
}
