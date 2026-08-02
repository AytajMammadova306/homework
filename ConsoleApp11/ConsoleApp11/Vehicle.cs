using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Vehicle
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public void Start()
        {
            Console.WriteLine("WoOOoOooOOOOOOO");
        }
        public void Stop()
        {
            Console.WriteLine("EEEEeeeeeeeeuuuu");
        }
    }
}
