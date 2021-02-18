using System.Collections.Generic;
using System.Linq;

namespace MagicStaircase.Core
{
    public class Deck
    {
        public bool HasCards => deck.Any();
        public int TotaCards => deck.Count();
        private List<int> deck;

        public Deck()
        {
            Reset();
        }

        public void Reset()
        {
            deck = Enumerable.Range(2, 97).ToList().RandomizeList().ToList();
        }

        public int TakeCard()
        {
            int num = deck.First();
            deck.Remove(num);
            return num;
        }
      
    }
}
