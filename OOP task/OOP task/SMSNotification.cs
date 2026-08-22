using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class SMSNotification:Notification
    {
        public override void Sent()
        {
            Console.WriteLine("SMS vasitəsilə bildiriş göndərildi.");
        }
    }
}
