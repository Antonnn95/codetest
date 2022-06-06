using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamesConsole2.Classes
{
    public class Dealer
    {
        private Deck _deck;


        public Dealer(Deck deck)
        {
            _deck = deck;

        }

        public void ShuffleDeck()
        {
            for (int i = 0; i < _deck._cards.Count; i++)
            {
                Random random = new Random();
                int number = random.Next(0, _deck._cards.Count);
                Card card = _deck._cards[i];
                _deck._cards.Remove(card);
                _deck._cards.Insert(number, card);
            }
        }
        public List<Card> DealHand()
        {
            List<Card> dealtHand = new List<Card>();
            Card card1 = _deck._cards[0];
            Card card2 = _deck._cards[1];
            dealtHand.Add(card1);
            _deck._cards.Remove(card1);
            dealtHand.Add(card2);
            _deck._cards.Remove(card2);
            return dealtHand;
        }
        public List<Card> DealFlop()
        {
            List<Card> dealtFlop = new List<Card>();
            Card card1 = _deck._cards[0];
            Card card2 = _deck._cards[1];
            Card card3 = _deck._cards[2];
            Card card4 = _deck._cards[3];
            
            dealtFlop.Add(card2);
            dealtFlop.Add(card3);
            dealtFlop.Add(card4);

            _deck._cards.Remove(card1);
            _deck._cards.Remove(card2);
            _deck._cards.Remove(card3);
            _deck._cards.Remove(card4);
            return dealtFlop;
            
        }
    }
}
