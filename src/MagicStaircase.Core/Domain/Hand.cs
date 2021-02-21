using System.Collections.Generic;

namespace MagicStaircase.Core
{
    public class Hand
    {
        public const int PlayerHandCount = 8;
        public const int MandatoryMinCardPerTurn = 2;
        public int PlayedCards => PlayerHandCount - TotaCards;
        public bool CanPass => PlayedCards >= MandatoryMinCardPerTurn;

        public List<Card> Cards { get; private set; }
        public int TotaCards => Cards.Count;

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void Add(int number)
        {
            Cards.Add(new Card(number));
        }

        public void Place(int number)
        {
            Cards.RemoveAll(x => x.Number == number);
        }

        public bool CanPlayCards()
        {
            return TotaCards <= PlayerHandCount - MandatoryMinCardPerTurn;
        }
    }
}
