using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Eat()
        {
            Console.WriteLine("Ate!");
        }
        public void Sleep()
        {
            Console.WriteLine("Slept");
        }
    }
}
