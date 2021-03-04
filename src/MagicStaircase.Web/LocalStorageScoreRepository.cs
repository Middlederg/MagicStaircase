using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using MagicStaircase.Core;

namespace MagicStaircase.Web
{
    public class LocalStorageScoreRepository : Core.IScoreReporitory
    {
        private const string achievementList = nameof(achievementList);

        private readonly Blazored.LocalStorage.ILocalStorageService localStorage;

        public LocalStorageScoreRepository(ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;
        }

        public async Task AddScore(Score score)
        {
            var scores = await GetScores();
            var result = scores.Select(x => x.ToViewModel()).ToList();
            result.Add(score.ToViewModel());
            await localStorage.SetItemAsync(achievementList, result);
        }

        public async Task<IEnumerable<Score>> GetScores()
        {
            var exists = await localStorage.ContainKeyAsync(achievementList);
            if (!exists)
            {
                return new List<Score>();
            }
            var scores = await localStorage.GetItemAsync<List<ScoreViewModel>>(achievementList);
            return scores.Select(x => new Score(x));
        }

        public async Task RemoveScore(Score score)
        {
            var scores = await GetScores();
            var result = scores.Select(x => x.ToViewModel()).ToList();
            result.Remove(score.ToViewModel());
            await localStorage.SetItemAsync(achievementList, result);
        }
    }
}
