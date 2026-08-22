using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class PayPal:PaymentMethod
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"{amount} AZN PayPal hesabı ilə ödənildi.");
        }
    }
}
