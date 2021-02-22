using System.Collections.Generic;
using System.Threading.Tasks;
using MagicStaircase.Core;

namespace MagicStaircase.Web
{
    public class LocalStorageScoreRepository : Core.IScoreReporitory
    {
        public async Task AddScore(Score score)
        {
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Score>> GetScores()
        {
            var result = new List<Score>();
            return await Task.FromResult(result);
        }
    }
}
