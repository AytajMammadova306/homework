using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    internal class SmsNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS göndərildi: {message}");
        }
    }
}
