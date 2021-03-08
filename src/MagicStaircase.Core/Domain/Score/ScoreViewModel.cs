using System;

namespace MagicStaircase.Core
{
    public class ScoreViewModel
    {
        public string PlayerName { get; set; }
        public int Points { get; set; }
        public DateTime Date { get; set; }
        public int Seconds { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var other = (ScoreViewModel)obj;

            return PlayerName.Equals(other.PlayerName) &&
                Seconds == other.Seconds &&
                Points == other.Points &&
                Date == other.Date;
        }

        // override object.GetHashCode
        public override int GetHashCode() => Points.GetHashCode() * PlayerName.GetHashCode() * Seconds.GetHashCode() * Date.GetHashCode();

    }
}
