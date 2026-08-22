using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class BankAccount
    {
        private string _accountNumber;
        private double _balance;

        public double Balance { get { return _balance; } }

        public void Deposite(double amount)
        {
            if (amount <= 0) Console.WriteLine("you cant add negative number");
            else _balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > _balance) Console.WriteLine("you can't withdraw more than you have in balance");
            else if (amount < 0) Console.WriteLine("You can withdraw negative");
            else _balance -= amount;
        }
    }
}
