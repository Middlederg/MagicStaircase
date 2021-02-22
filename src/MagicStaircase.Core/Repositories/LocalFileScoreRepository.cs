using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MagicStaircase.Core;
using Newtonsoft.Json;

namespace MagicStaircase.Core.Repositories
{
    public class LocalFileScoreRepository : IScoreReporitory
    {
        public LocalFileScoreRepository()
        {
            Directory.CreateDirectory(Configuration.ScoresDirectory);
        }

        public async Task<IEnumerable<Score>> GetScores()
        {
            if (!File.Exists(Configuration.ScoresFile))
            {
                return new List<Score>();
            }

            using (var streamReader = new StreamReader(Configuration.ScoresFile))
            {
                var json = await streamReader.ReadToEndAsync();
                return Score.Deserialize(json);
            }
        }

        public async Task AddScore(Score score)
        {
            var scores = (await GetScores()).ToList();
            using (var streamReader = new StreamWriter(Configuration.ScoresFile))
            {
                scores.Add(score);
                var json = JsonConvert.SerializeObject(scores.Select(x => x.ToViewModel()));
                await streamReader.WriteAsync(json);
            }
        }
    }
}
