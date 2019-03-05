using System;
using System.Collections.Generic;

namespace Stack_of_Cards
{
    public class Deck : Stack<Card>
    {
        private Stack<Card> cards = new Stack<Card>();
        public Deck()
        {
            foreach (var suit in (Suit[]) Enum.GetValues(typeof(Suit)))
            {
                for (var i = 0; i < 14; i++)
                {
                    var card = new Card(i + 1, suit);
                    cards.Push(card);
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
                var card = cards.Pop();
                Console.WriteLine($"Drew {card.Value} of {card.SuitValue}");
            }
        }
    }
}