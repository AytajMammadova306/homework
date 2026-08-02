using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Patient:Person
    {
        public void TakeMedicine()
        {
            Console.WriteLine("medicine taken");
        }
    }
}
