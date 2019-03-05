using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_of_Cards
{
    public class Deck : Stack<Card>
    {
        private Stack<Card> _cards = new Stack<Card>();
        public Deck()
        {
            foreach (var suit in (Suit[]) Enum.GetValues(typeof(Suit)))
            {
                for (var i = 0; i < 14; i++)
                {
                    var card = new Card(i + 1, suit);
                    _cards.Push(card);
                }
            }
        }

        public void Draw(int drawCount = 1)
        {
            if (drawCount <= 0)
            {
                drawCount = 1;
            }

            for (var i = 0; i < drawCount; i++)
            {
                var card = _cards.Pop();
                Console.WriteLine($"Drew {card.Value} of {card.SuitValue}");
            }
        }

        public void Shuffle()
        {
            var cardList = _cards.ToList();
            
            // Implementation of the Sattolo Shuffle
            for (var i = cardList.Count; i > 1; i--)
            {
                var rng = new Random();
                var j = rng.Next(i);
                
                var temp = cardList[i - 1];
                cardList[i - 1] = cardList[j];
                cardList[j] = temp;
            }

            _cards = new Stack<Card>(cardList);
        }
    }
}