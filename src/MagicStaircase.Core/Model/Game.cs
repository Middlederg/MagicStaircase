using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicStaircase.Core
{
    public class Game
    {
        public const int PlayerCardCount = 8;
        public const int MinCardPerTurn = 2;

        public List<int> Deck { get; private set; }

        public List<int>[] Piles { get; private set; }

        public bool HasCards => Deck.Any();
        public int Points => 100 - Deck.Count();

        public Game()
        {
            Reset();
        }

        public void Reset()
        {
            Deck = Enumerable.Range(2, 97).ToList().RandomizeList().ToList();
            Piles = new List<int>[4];
            Piles[0] = new List<int>() { 1 };
            Piles[1] = new List<int>() { 1 };
            Piles[2] = new List<int>() { 99 };
            Piles[3] = new List<int>() { 99 };
        }

        public int TakeCard()
        {
            int num = Deck.First();
            Deck.Remove(num);
            return num;
        }

        public void AddToPile(int number, int pileIndx) => Piles[pileIndx].Add(number);
    }
}
