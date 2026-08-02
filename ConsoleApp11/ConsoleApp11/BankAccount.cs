using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class BankAccount
    {
        private decimal _balance;

        public decimal Balance { get { return _balance; } }
        public string AccountHolder { get; set; } = "test";

        public void Deposite(decimal amount)
        {
            if (amount <= 0) Console.WriteLine("you cant add negative number");
            else _balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > _balance) Console.WriteLine("you can't withdraw more than you have in balance");
            else if (amount < 0) Console.WriteLine("You can withdraw negative");
            else _balance -= amount;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"account holder {AccountHolder} has {_balance}");
        }
    }
}
