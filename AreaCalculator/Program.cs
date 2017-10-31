using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "4") 
            {
                // Menu
                Console.Clear();
                Console.WriteLine("chose n option");
                Console.WriteLine("1. Area of Rectangle");
                Console.WriteLine("2.Area of Triangle");
                Console.WriteLine("3. Area of Circle");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();


                if(choice == "1")
                {
                    // Rectangle
                }
                else if(choice == "2")
                {
                    // Triangle
                }
                else if(choice == "3")
                {
                    // Circle
                }


                // Wait
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue....");
                Console.ReadKey();




            }

        


















        }
    }
}
