using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    internal static class Checker
    {
        public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
