using System.Collections.Generic;
using System.Linq;

namespace MagicStaircase.Core
{
    public class Game
    {
        private Deck deck;
        public bool AreRemainingCards => deck.HasCards;
        public int Points() => 100 - deck.TotaCards - playerHand.TotaCards;

        private Hand playerHand;
        public IEnumerable<Card> HandCards => playerHand.Cards;
        public bool CanPass => playerHand.CanPass;

        public IEnumerable<Pile> Piles { get; private set; }

        public Game()
        {
            Reset();
        }

        public void Reset()
        {
            playerHand = new Hand();
            deck = new Deck();
            RefillHand();
            Piles = new List<Pile>
            {
                new Pile(Direction.Up, 0),
                new Pile(Direction.Up, 1),
                new Pile(Direction.Down, 2),
                new Pile(Direction.Down, 3)
            };
        }

        public void RefillHand()
        {
            foreach (int _ in Enumerable.Range(0, playerHand.PlayedCards))
            {
                if (deck.HasCards)
                {
                    playerHand.Add(deck.TakeCard());
                }
            }
        }

        public void Play(int number, int pileIndx)
        {
            playerHand.Place(number);
            Piles.ElementAt(pileIndx).Add(new Card(number));
        }

        public bool IsPlayableCard()
        {
            foreach (var pile in Piles)
            {
                if (HandCards.Any(card => pile.Fits(card)))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsGameEnd()
        {
            if (!IsPlayableCard())
            {
                return false;
            }

            return !playerHand.CanPlayCards();
        }
    }
}
