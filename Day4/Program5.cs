using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program5
    {
        public static void Main()
        {
            bool foundAFactor = false;
            int num = 2;

            for (int counter = 2; counter <= num - 1; counter++)
            {
                if (num % counter == 0) //if the remainder is 0 -> num is divisible by counter
                {
                    foundAFactor = true; //we found something that can divide counter
                    Console.WriteLine(counter);
                    break; //break out of the innermost loop
                }
            }

            if (foundAFactor == true)  // if (foundAFactor)
            {
                Console.WriteLine("Not a Prime");
            } else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
