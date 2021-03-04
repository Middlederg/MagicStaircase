using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicStaircase.Core
{
    public interface IScoreReporitory
    {
        Task AddScore(Score score);
        Task<IEnumerable<Score>> GetScores();
        Task RemoveScore(Score score);
    }
}