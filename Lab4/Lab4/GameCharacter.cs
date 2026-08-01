using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class GameCharacter
    {
        private string _name;
        private int _health;

        public void TakeDamage()
        {
            if (_health - 10 <= 0) Console.WriteLine("You need to heal ASAP");
            else _health -= 10;
        }
        public void Heal()
        {
            if(_health+10>100) Console.WriteLine("You are heal enough");
            else _health += 10;
        }
        public void PrintStatus()
        {
            Console.WriteLine($"Character named {_name} has {_health} health");
        }
    }
}
