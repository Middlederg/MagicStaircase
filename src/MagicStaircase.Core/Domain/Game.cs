using System.Collections.Generic;
using System.Linq;

namespace MagicStaircase.Core
{
    public class Game
    {
        public const int PlayerCardCount = 8;
        public const int MinCardPerTurn = 2;

        public List<int> Deck { get; private set; }

        public IEnumerable<Pile> Piles { get; private set; }

        public bool HasCards => Deck.Any();
        public int Points(int cardsInHand) => 100 - Deck.Count() - cardsInHand;

        public Game()
        {
            Reset();
        }

        public void Reset()
        {
            Deck = Enumerable.Range(2, 97).ToList().RandomizeList().ToList();
            Piles = new List<Pile>
            {
                new Pile(Direction.Up),
                new Pile(Direction.Up),
                new Pile(Direction.Down),
                new Pile(Direction.Down)
            };
        }

        public int TakeCard()
        {
            int num = Deck.First();
            Deck.Remove(num);
            return num;
        }

        public void AddToPile(int number, int pileIndx) => Piles.ElementAt(pileIndx).Add(new Card(number));
    }
}
