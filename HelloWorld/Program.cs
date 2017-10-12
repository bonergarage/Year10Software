using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
         
           Console.ForegroundColor = ConsoleColor.Blue;
           Console.WriteLine("HelloWorld!");
           Console.Beep(4200, 2000);
           Console.WriteLine("HelloWorld!!!!");
            Console.Title = "My Program";
           Console.ReadLine();
        } 
    }
}
