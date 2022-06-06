using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamesConsole2.Classes
{
    public class Game
    {
        public Dealer _dealer;
        public List<Player> _players;
        public List<Card> _flop;

        public Game(Dealer dealer)
        {
            _dealer = dealer;
            _players = new List<Player>();
            _flop = new List<Card>();
        }

        public void Shuffle()
        {
            _dealer.ShuffleDeck();
            _dealer.ShuffleDeck();
            _dealer.ShuffleDeck();


        }

        public void Deal()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i]._hand = _dealer.DealHand();
            }
            
        }

        public void DealFlop()
        {
            _flop = _dealer.DealFlop();
        }

        public void RevealFlop()
        {
            Console.WriteLine();
            Console.WriteLine("Flop");
            foreach (Card card in _flop)
            {
                Console.WriteLine($"{card.Value}, {card.Suit}");
            }
        }

        public void RevealHands()
        {

            foreach (Player player in _players)
            {
                Console.WriteLine();
                Console.WriteLine(player._name);
                player.RevealHand();
            }
        }
    }
}
