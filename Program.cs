using CardGamesConsole2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamesConsole2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            deck.AddCards(4);

            Dealer dealer = new Dealer(deck);
            Game game = new Game(dealer);

            Console.WriteLine("Choose how many players");
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < numOfPlayers; i++)
            {
                Player player = new Player();
                Console.WriteLine("What is your name?");
                player._name = Console.ReadLine();
                game._players.Add(player);
            }

            game.Shuffle();

            game.Deal();

            game.DealFlop();

            game.RevealFlop();

            game.RevealHands();

            Console.WriteLine();

            Console.ReadLine();



        }
    }
}
