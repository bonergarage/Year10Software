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
            // Define array of answers
            string[] answer = { "No", "Yes", "Maybe", "For sure", "fight me cunt" };
            
            // Prompt user
            Console.Write("Ask me a question that can be answered 'yes' or 'no'. type 'Exit' to leave");

            // Only play the game if the user doesn't type 'Exit'
            if(Console.ReadLine() != "Exit")
            {
                // Pick a random answer
                Random rnd = new Random();

                // Print out random item from array
                Console.WriteLine(answer[rnd.Next(9)]);

                // Blank line
                Console.WriteLine("");

                // Go again
                playgame();
            }
           
        }
    }
}
