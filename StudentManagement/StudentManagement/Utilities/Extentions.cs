using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Utilities
{
    internal static class Extentions
    {
        public static bool TryAgain()
        {
            do
            {
                Console.WriteLine("Would you like to Try Again?(Y/N)");
                string answer= Console.ReadLine();
                Console.Clear();
                if (answer.ToUpper() == "Y") return true;
                else if (answer.ToUpper() == "N") return false;
                else
                {
                    Console.WriteLine("You should enter Y or N");
                }
            } while (true);
        }
    }
}
