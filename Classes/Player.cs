using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamesConsole2.Classes
{
    public class Player
    {
        public List<Card> _hand { get; set; }
        public string _name { get; set; }

        public void RevealHand()
        {
            foreach (Card card in _hand)
            {
                Console.WriteLine($"{card.Value}, {card.Suit}");
            }
        }
    }
}
