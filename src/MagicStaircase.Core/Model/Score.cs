using System;
using System.Drawing;
using System.Windows.Forms;

namespace MagicStaircase.Core
{
    public class Score
    {
        public Player Player { get; }
        public int Points { get; }
        public DateTime Date { get; }
        public Time Time { get; }

        public Score(Player player, int points, Time time)
        {
            Player = player;
            Points = points;
            Date = DateTime.Now;
            Time = time;
        }
    }
}
