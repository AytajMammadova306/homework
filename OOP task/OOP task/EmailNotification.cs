using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class EmailNotification:Notification
    {
        public override void Sent()
        {
            Console.WriteLine("E-poçt vasitəsilə bildiriş göndərildi.");
        }
    }
}
