using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    internal class Box<T>
    {
        private T _item;

        public void Put(T item)
        {
            _item = item;
            Console.WriteLine("It was placeed in box");
        }
        public T Get()
        {
            return _item;
        }
    }
}
