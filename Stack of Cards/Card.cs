namespace Stack_of_Cards
{
    public struct Card
    {
        public int Value { get; }
        public Suit SuitValue { get; }

        public Card(int value, Suit suit)
        {
            Value = value;
            SuitValue = suit;
        }
    }
}