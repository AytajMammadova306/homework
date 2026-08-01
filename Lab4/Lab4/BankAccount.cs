using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class BankAccount
    {
        private string _ownerName;
        private double _balance;

        public void CreateAccount(string ownerName, double balanace)
        {
            _balance = balanace;
            _ownerName=ownerName;
        }
        public void Deposite(double amount)
        {
            _balance += amount;
        }
        public void Withdraw(double amount )
        {
            if (_balance - amount >= 0) _balance -= amount;
            else Console.WriteLine("You dont have enough money");
        }
        public void ShowBalance()
        {
            Console.WriteLine($"you have {_balance}");
        }
    }
}
