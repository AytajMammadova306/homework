using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Student
    {
        private string _name;
        private int _grade;

        public void SetStudent(string name, int grade)
        {
            _grade = grade;
            _name = name;
        }
        public bool HasPassed()
        {
            return _grade >= 60;
        }
        public void PrintStudent()
        {
            Console.WriteLine($"Student :{_name}, Passed:{HasPassed()}");
        }
    }
}
