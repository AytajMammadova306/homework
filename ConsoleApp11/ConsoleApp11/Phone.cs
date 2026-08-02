using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Phone
    {
        private int _batteryLevel;
        private bool _isLocked;

        public string Brand {  get; set; }
        public string Model { get; set; }
        public int BatteryLevel { get { return _batteryLevel; } }
        public bool IsLocked { get { return _isLocked; } }

        public void Charge(int amount)
        {
            if (_batteryLevel + amount >= 100) Console.WriteLine("It is charged enough");
            else _batteryLevel += amount;
        }
        public void UsePhone(int amount)
        {
            if (_batteryLevel - amount <10 && _batteryLevel - amount > 0) Console.WriteLine("Its battery is too low ");
            else if(_batteryLevel - amount < 0) Console.WriteLine("it cant be less than 0");
            else if(_batteryLevel - amount ==0) Console.WriteLine("Phone is dead");
            else _batteryLevel -= amount;
        }
        public void Lock()
        {
            if (_isLocked) Console.WriteLine("It is already locked");
            else _isLocked = true;
        }
        public void Unlock()
        {
            if (!_isLocked) Console.WriteLine("It is already Unlocked");
            else _isLocked = false;
        }
        public void PrintStatus()
        {
            Console.WriteLine($"Phone with model {Model} brand of {Brand} is with battery level {BatteryLevel} and it is {(IsLocked?"Locked":"Unlocked")}");
        }



    }
}
