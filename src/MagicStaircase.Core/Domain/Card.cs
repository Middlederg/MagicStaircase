namespace MagicStaircase.Core
{
    public class Card
    {
        public int Number { get; }

        public Card(int number)
        {
            Number = number;
        }

        public override string ToString() => Number.ToString();

        public bool Greater(Card card) => Number > card.Number;
        public bool Lower(Card card) => Number < card.Number;
        public bool TenLess(Card card) => Number == card.Number - 10;
        public bool TenMore(Card card) => Number == card.Number + 10;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return ((Card)obj).Number == Number;
        }
        public override int GetHashCode() => Number.GetHashCode();
    }
}
