using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGame
{
    class Program
    {
        static void Main(string[] args)
        {
            float money = 10;
            playGame(ref money);
        }

        private static void playGame(ref float money)
        {
            Console.Clear();
            float betAmount = Makebet(ref money);
            Random rnd = new Random();
            int playerTotal = DealCards(rnd, "You");
            int dealerTotal = DealCards(rnd, "The dealer");
            bool playerWins = determinewinner(playerTotal, dealerTotal);
            PayOut(playerWins, betAmount ref money);
            Menu(ref money;)
        }

        private static float MakeBet(ref float money)

        private static int DealCards(Random rnd, string player)

        private static bool determineWinner(int player, int dealer)

        private static void PayOut(bool playerWins, float betAmount, ref float money)

        private static void Menu(ref float money)
        {
            Console.Write("Would You Like Another Game? y/n: ");
            if (Console.ReadLine() == "y")
            {
                playGame(ref money);
            }
        }













    }
}
