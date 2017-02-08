using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program6
    {
        public static void Main()
        {
            for (int num=1; num <= 100; num++)
            {
                //in here we want to check whether num is a prime.

                bool foundAFactor = false;

                for (int counter = 2; counter <= num - 1; counter++)
                {
                    if (num % counter == 0) //if the remainder is 0 -> num is divisible by counter
                    {
                        foundAFactor = true; //we found something that can divide counter
                        break; //break out of the innermost loop
                    }
                }

                if (foundAFactor == false) // if (!foundAFactor)
                {
                    Console.WriteLine("{0} is a prime",num);
                }

            }
        }
    }
}
