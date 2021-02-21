using System.Collections.Generic;
using System.Linq;

namespace MagicStaircase.Core
{
    public class Game
    {
        private Deck deck;
        public bool AreRemainingCards => deck.HasCards;
        public int Points() => 100 - deck.TotaCards - PlayerHand.TotaCards;

        public Hand PlayerHand { get; private set; }
        public bool CanPass => PlayerHand.CanPass;

        public IEnumerable<Pile> Piles { get; private set; }

        public Game()
        {
            Reset();
        }

        public void Reset()
        {
            PlayerHand = new Hand();
            deck = new Deck();
            RefillHand().ToList();
            Piles = new List<Pile>
            {
                new Pile(Direction.Up, 0),
                new Pile(Direction.Up, 1),
                new Pile(Direction.Down, 2),
                new Pile(Direction.Down, 3)
            };
        }

        public IEnumerable<int> RefillHand()
        {
            foreach (int _ in Enumerable.Range(0, PlayerHand.PlayedCards))
            {
                if (deck.HasCards)
                {
                    var newNumber = deck.TakeCard();
                    PlayerHand.Add(newNumber);
                    yield return newNumber;
                }
            }
        }

        public void Play(int number, int pileIndx)
        {
            PlayerHand.Place(number);
            Piles.ElementAt(pileIndx).Add(new Card(number));
        }

        public bool CardCanBePlaced(Card card)
        {
            return Piles.Any(pile => pile.Fits(card));
        }

        public bool IsPlayableCard()
        {
            foreach (var pile in Piles)
            {
                if (PlayerHand.Cards.Any(card => pile.Fits(card)))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsGameEnd()
        {
            if (IsPlayableCard())
            {
                return false;
            }

            return !PlayerHand.CanPlayCards();
        }
    }
}
