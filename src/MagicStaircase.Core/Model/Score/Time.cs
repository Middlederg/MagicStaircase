using System;

namespace MagicStaircase.Core
{
    public class Time
    {
        public int Seconds { get; private set; }
        public void NextSecond() => Seconds++;

        public Time(int seconds = 0)
        {
            Seconds = seconds;
        }

        public override string ToString() => TimeSpan.FromSeconds(Seconds).ToString(@"mm\:ss");
        public string ToText()
        {
            if (Seconds < 60)
                return $"{Seconds} seconds";

            if (Seconds < 60 * 60)
            {
                if (Seconds % 60 == 0)
                    return $"{Seconds / 60} minutes"; 
                return $"{Seconds / 60} minutes and {Seconds % 60} seconds";
            }

            if (Seconds % 60 * 60 == 0)
                return $"{Seconds / 60 * 60} hours";
            return $"{Seconds / 60  * 60} hours, {Seconds % 60 * 60 / 60} minutes and {Seconds % 60 * 60 % 60} seconds";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Time)obj;
            return other.Seconds == Seconds;
        }

        public override int GetHashCode() => Seconds.GetHashCode();

        internal bool IsLowerThan(Time minimumTime) => Seconds < minimumTime.Seconds;
        
    }
}
