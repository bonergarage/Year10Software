using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;
            int computerScore = 0;
            bool repeat = true;

            while(repeat == true)
            {
                string result = "draw";
                PrintScore(ref userScore, ref computerScore);                   // Print scores
                string userChoice = UserTurn();                                 // User's turn
                string computerChoice = computerTurn();                         // Computer's turn
                result = DetermineWinner(userChoice, computerChoice);           // Determine the Winner
                GiveFeedback(result, userChoice, computerChoice);               // Provide feedback
                UpdateScores(result, ref userScore, ref computerScore);       // Update the score
                repeat = PlayAgain();                                           // Ask to play again
            }

        }

        private static void PrintScore(ref int userScore, ref int computerScore)
        {
            Console.Clear();
            Console.WriteLine("User: " + userScore + "      computer:" + computerScore);
        }
        private static string UserTurn()
        {
            return "rock";
        }
        private static string computerTurn()
        {
            return "paper";
        }
        private static string DetermineWinner(string user, string computer)
        {
            return "user";
        }
        private static void GiveFeedback(string result, string userchoice, string computerChoice)
        {

        }
        private static bool PlayAgain()
        {
            return true;
        }
        private static void UpdateScores(string result, ref int userScore, ref int computerScore)
        {

        }
        private static string UserTurn()
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");
                Console.WriteLine("3: Scissors");
                Console.WriteLine("Your choice: ");
                choice = Console.ReadLine();
            }

            if (choice == "1")
            {
                return "Rock";
            }
            else if ()
        }

    }
    
        


}
