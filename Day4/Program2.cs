using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program2
    {
        public static void Main()
        {
            bool wrongPIN = true;
            int numTries = 0;
            string PIN = "123456";

            Console.WriteLine("Welcome to the Bank of ISS");
            do
            {
                Console.Write("Enter your PIN: ");
                string input = Console.ReadLine();
                numTries++;

                if (input == PIN)
                {
                    Console.WriteLine("PIN accepted. You can access your account now");
                    wrongPIN = false;
                }
                else
                {
                    if (numTries == 3)
                    {
                        Console.WriteLine("Too many wrong PIN entries.");
                    } else
                    {
                        Console.WriteLine("Incorrect PIN. Please try again.");
                    }
                    wrongPIN = true;
                }
            } while (wrongPIN && numTries < 3) ;
        }
    }
}
