using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicStaircase.Core
{
    public class Pile
    {
        private readonly List<Card> cards;
        public Card LastCard => cards.Last();

        public Direction Direction { get; }
        public int Index { get; }

        public Pile(Direction direction, int index)
        {
            Index = index;
            Direction = direction;
            cards = new List<Card>();
            if (direction == Direction.Up) cards.Add(new Card(1));
            if (direction == Direction.Down) cards.Add(new Card(99));
        }

        public bool Fits(Card card)
        {
            if (Direction == Direction.Up)
            {
                return LastCard.Lower(card) ||LastCard.TenMore(card) ;
            }
            if (Direction == Direction.Down)
            {
                return LastCard.Greater(card) || LastCard.TenLess(card);
            }
            return false;
        }

        public void Add(Card card)
        {
            if (!Fits(card))
            {
                throw new Exception($"Card {card} can not be Added to pile {this}");
            }
            cards.Add(card);
        }

        public override string ToString() => string.Join(", ", cards);
    }
}
