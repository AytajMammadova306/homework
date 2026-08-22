using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class PaymentProcessor
    {
        public void Pay(PaymentMethod method, double amount)
        {
            method.ProcessPayment(amount);
        }
    }
}
