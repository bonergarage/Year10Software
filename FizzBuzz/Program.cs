using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop 100 Times
            for (int i = 1; i<= 100000; i++)
            {
                // If divisble by both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    Console.Beep();
                }
                // If divisble by 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // If divisble by 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Otherwise, just print the number
                else
                {
                    Console.WriteLine(i);
                }
               
            }

            // Wait
            Console.WriteLine("\nPress any ket to exit...");
            Console.ReadKey();
     




        }
    }
}
