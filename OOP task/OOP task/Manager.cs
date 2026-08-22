using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class Manager:Employee
    {
        public int TeamSize { get; set; }
        public void ConductMeeting()
        {
            Console.WriteLine($"{Name} {TeamSize} nəfərlik komanda ilə iclas keçirir.");
        }
    }
}
