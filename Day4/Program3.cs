using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program3
    {
        public static void Main()
        {
            int i = 1; // (a)
            while (i <= 100) //(b)
            {
                Console.WriteLine(i);
                i++; // (c)
            }

            for (int j=1; j<=100; j++ ) //for ( (a); (b); (c) ) 
            {
                Console.WriteLine(j);
            }

        }
    }
}
