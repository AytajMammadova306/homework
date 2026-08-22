using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public void Work()
        {
            Console.WriteLine($"{Name} is working...");
        }
    }
}
