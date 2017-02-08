using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program8
    {
        public static void Main()
        {
            Console.WriteLine("{0} {1}", "Name".PadRight(20,' '), "Score".PadLeft(5,' '));
            Console.WriteLine("{0} {1}", "John Smith".PadRight(20, ' '), "80".PadLeft(5, ' '));
            Console.WriteLine("{0} {1}", "Jim".PadRight(20, ' '), "30".PadLeft(5, ' '));
            Console.WriteLine("{0} {1}", "Sammy".PadRight(20, ' '), "110".PadLeft(5, ' '));
            Console.WriteLine("{0} {1}", "Tan Ah Kaw".PadRight(20, ' '), "1000".PadLeft(5, ' '));
        }
    }
}
