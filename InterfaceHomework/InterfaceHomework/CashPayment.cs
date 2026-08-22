using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    internal class CashPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"{amount} AZN nağd ödənildi.");
        }
    }
}
