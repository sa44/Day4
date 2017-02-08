using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program9
    {
        public static void Main()
        {
            Console.Write("Please enter x1 y1 x2 y2: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            int x1 = Convert.ToInt32(numbers[0]);
            int y1 = Convert.ToInt32(numbers[1]);
            int x2 = Convert.ToInt32(numbers[2]);
            int y2 = Convert.ToInt32(numbers[3]);

            Console.WriteLine("Distance from ({0},{1}) to ({2},{3}) is {4}",
                x1, y1, x2, y2, Math.Sqrt( Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2)));
        }
    }
}
