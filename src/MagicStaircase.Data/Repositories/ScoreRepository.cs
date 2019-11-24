using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MagicStaircase.Core;

namespace MagicStaircase.Data
{
    public static class ScoreRepository
    {
        public static async Task<IEnumerable<Score>> GetScores()
        {
            using (var streamReader = new StreamReader(Configuration.ScoresFile))
            {
                var json = await streamReader.ReadToEndAsync();
                return Score.Deserialize(json);
            }
        }

        public static async Task AddScore(Player player, int points, Time time)
        {
            var scores = (await GetScores()).ToList();
            using (var streamReader = new StreamWriter(Configuration.ScoresFile))
            {
                scores.Add(new Score(player, points, time));
                var json = string.Join("", scores.Select(x => x.Serialize()));
                await streamReader.WriteAsync(json);
            }
        }
    }
}
