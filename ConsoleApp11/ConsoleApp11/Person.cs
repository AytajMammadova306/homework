using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}");
        }
    }
}
