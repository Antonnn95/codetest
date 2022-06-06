using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamesConsole2.Classes
{
    public class Deck
    {
        public List<Card> _cards;

        public Deck()
        {
            _cards = new List<Card>();
        }

        public void AddCards(int numberOfColors)
        {
            for (int i = 0; i < numberOfColors; i++)
            {
                CreateCard((CardSuit)i);
            }
        }

        private void CreateCard(CardSuit color)
        {
            for (int i = 2; i < 15; i++)
            {
                _cards.Add(new Card() { Suit = color, Value = (CardValue)i });
            }

        }
    }
}
