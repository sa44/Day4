using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program10
    {
        public static void Main()
        {
            Console.Write("Enter your NRIC:");
            string nric = Console.ReadLine();

            if (nric[0] == 'S')
                Console.WriteLine("You're old.");
            else if (nric[0] == 'T')
                Console.WriteLine("You're young.");
        }
    }
}
