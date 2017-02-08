using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program4
    {
        public static void Main()
        {
            //Print out all even number in the range of 1-100

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
