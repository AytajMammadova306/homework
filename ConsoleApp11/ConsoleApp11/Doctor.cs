using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Doctor:Person
    {
        public void ExaminePatient()
        {
            Console.WriteLine("patient examined");
        }
    }
}
