using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Modul
{
    internal class Student
    {
        public static int _id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Grade { get; set; }
        public Student(string name, string surname, double grade)
        {
            Id = ++_id;
            Name = name;
            Surname = surname;
            Grade = grade;
        }
        public override string ToString() { return $"{Id}|{Name}|{Surname}|{Grade}"; }
    }
}
