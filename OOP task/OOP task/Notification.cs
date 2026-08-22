using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class Notification
    {
        public virtual void Sent()
        {
            Console.WriteLine("Standart bildiriş göndərildi.");
        }
    }
}
