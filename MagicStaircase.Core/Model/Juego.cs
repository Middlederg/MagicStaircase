using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicStaircase.Core.Model
{
    public class Juego
    {
        public const int NumCartasMano = 8;
        public const int NumCartasPorTurno = 2;

        public List<int> Baraja { get; private set; }

        public List<int>[] Montones { get; private set; }

        public bool HasCards => Baraja.Any();
        public int Puntuacion => 98 - Montones.Sum(x=> x.Count);

        public Juego()
        {
            Reset();
        }

        public void Reset()
        {
            Baraja = Enumerable.Range(2, 97).ToList().RandomizeList().ToList();
            Montones = new List<int>[4];
            Montones[0] = new List<int>() { 1 };
            Montones[1] = new List<int>() { 1 };
            Montones[2] = new List<int>() { 99 };
            Montones[3] = new List<int>() { 99 };
        }

        public int GetCard()
        {
            int num = Baraja.First();
            Baraja.Remove(num);
            return num;
        }

        public void AddToMonton(int numero, int indx) => Montones[indx].Add(numero);
    }
}
