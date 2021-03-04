using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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

        public string Message
        {
            get
            {
                if (Points >= 100) return "¡¡Best score ever!!";
                if (Points > 95) return "¡¡Magnifique!!";
                if (Points > 90) return "¡Excelent!";
                if (Points > 85) return "¡Well done!";
                if (Points > 80) return "Not bad";
                return "You have to get better...";
            }
        }

        public Score(ScoreViewModel score)
        {
            Player = new Player(score.PlayerName);
            Points = score.Points;
            Date = score.Date;
            Time = new Time(score.Seconds);
        }

        public static IEnumerable<Score> Deserialize(string json)
        {
            var scores = JsonConvert.DeserializeObject<IEnumerable<ScoreViewModel>>(json);
            foreach (var score in scores)
            {
                yield return new Score(score);
            }
        }

        public ScoreViewModel ToViewModel()
        {
            return new ScoreViewModel()
            {
                Date = Date,
                PlayerName = Player.ToString(),
                Points = Points,
                Seconds = Time.Seconds
            };
        }

        public override string ToString() => $"{Player} ({PointsText})";

        public string PointsText => $"{Points} point{(Points == 1 ? "" : "s")}";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var other = (Score)obj;

            return Player.Equals(other.Player) &&
                Time.Seconds == other.Time.Seconds &&
                Points == other.Points &&
                Date == other.Date;
        }

        // override object.GetHashCode
        public override int GetHashCode() => Points.GetHashCode() * Player.GetHashCode() * Time.GetHashCode() * Date.GetHashCode();
    }
}
