using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class Developer:Employee
    {
        public string ProgrammingLanguage { get; set; }
        public void WriteCode()
        {
            Console.WriteLine($"{Name}, {ProgrammingLanguage} dilində kod yazır.");
        }


    }
}
