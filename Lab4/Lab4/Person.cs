using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Person
    {
        private int _age;
        private string _name;
        public void SetName(string name, int age)
        {
            _name=name;
            _age=age;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: "+_name+"\t Age: "+_age);
        }
    }
}
