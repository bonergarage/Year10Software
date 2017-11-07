using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8BALL
{
    class Program
    {
        static void Main(string[] args)
        {
            playgame();
        }


        private static void playgame()
        {
            string[] answer = { "No", "Yes", "Maybe", "For sure" };
            Console.Write("Ask me a question (or type 'Exit'): ");
            string choice = Console.ReadLine();
            Random rnd = new Random();
            Console.WriteLine(Answers[rnd.Next(0, 4)]);
            Console.ReadKey();
        }
    }
}
