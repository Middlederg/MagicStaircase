using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        private Score(ScoreViewModel score)
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

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        
    }
}
