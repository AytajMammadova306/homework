using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_LINQ.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Department: {Department}, Salary: {Salary}, Age:{Age}";
        }
    }
}
