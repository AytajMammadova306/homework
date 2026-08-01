using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Employee
    {
        private string _name;
        private double _salary;

        public void SetEmployee(string name, double salary)
        {
            _name = name;
            _salary = salary;
        }
        public void IncreaseSalary(double amount)
        {
            _salary += amount;
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Salary of employee {_name} is {_salary}");
        }
    }
}
