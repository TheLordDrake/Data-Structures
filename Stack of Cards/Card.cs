namespace Stack_of_Cards
{
    public struct Card
    {
        public int Value { get; set; }
        public Suit SuitValue { get; set; }

        public Card(int value, Suit suit)
        {
            Value = value;
            SuitValue = suit;
        }
    }
}