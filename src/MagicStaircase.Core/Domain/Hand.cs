using System.Collections.Generic;

namespace MagicStaircase.Core
{
    public class Hand
    {
        public const int PlayerHandCount = 8;
        public const int MandatoryMinCardPerTurn = 2;
        public int PlayedCards => PlayerHandCount - TotaCards;
        public bool CanPass => PlayedCards >= MandatoryMinCardPerTurn;

        private readonly List<Card> cards;
        public IReadOnlyCollection<Card> Cards => cards;
        public int TotaCards => cards.Count;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void Add(int number)
        {
            cards.Add(new Card(number));
        }

        public void Place(int number)
        {
            cards.RemoveAll(x => x.Number == number);
        }

        public bool CanPlayCards()
        {
            return TotaCards <= PlayerHandCount - MandatoryMinCardPerTurn;
        }
    }
}
