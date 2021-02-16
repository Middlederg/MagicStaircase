using System;
using System.Collections.Generic;

namespace MagicStaircase.Core
{
    public class Pile
    {
        private readonly List<Card> cards;
        public Card LastCard => cards.Last();

        public Direction Direction { get; }

        public Pile(Direction direction)
        {
            Direction = direction;
            cards = new List<Card>();
            if (direction == Direction.Up) cards.Add(new Card(1));
            if (direction == Direction.Down) cards.Add(new Card(100));
        }

        public bool Fits(Card card)
        {
            if (Direction == Direction.Up)
            {
                return LastCard.Greater(card) || LastCard.TenLess(card);
            }
            if (Direction == Direction.Down)
            {
                return LastCard.Lower(card) || LastCard.TenMore(card);
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
