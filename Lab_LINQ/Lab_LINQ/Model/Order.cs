using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_LINQ.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
