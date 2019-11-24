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
