using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    internal interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
}
