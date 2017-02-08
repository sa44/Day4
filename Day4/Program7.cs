using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program7
    {
        public static void Main()
        {
            string firstname = Console.ReadLine();
            string secondname = Console.ReadLine();

            //display alphabetically
            if (firstname.CompareTo(secondname) < 0 )
            {
                Console.WriteLine(firstname);
                Console.WriteLine(secondname);
            } else
            {
                Console.WriteLine(secondname);
                Console.WriteLine(firstname);
            }
        }
    }
}
