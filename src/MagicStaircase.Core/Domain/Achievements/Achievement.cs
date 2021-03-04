using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicStaircase.Core
{
    public class Achievement
    {
        private readonly string name;
        private readonly List<IUnlockingStrategy> unlockingStrategies;

        public Achievement(string name, params IUnlockingStrategy[] unlockingStrategies)
        {
            this.name = name;
            this.unlockingStrategies = unlockingStrategies.ToList();
        }

        public bool TryToUnlockAchievement(Score score) => unlockingStrategies.All(x => x.IsUnlocked(score));
        public bool TryToUnlockAchievement(int points, Time time)
        {
            var score = new Score(new Player(""), points, time);
            return unlockingStrategies.All(x => x.IsUnlocked(score));
        }

        public override string ToString() => name;

        public string Description() => $"To unlock this achievement, you must: {UnlockingStrategiesText}";
        public string UnlockingStrategiesText => string.Join(", ", unlockingStrategies);

        public bool IsGold() => name.ToUpper().Equals("GOLD MEDAL");
        public bool IsSilver() => name.ToUpper().Equals("SILVER MEDAL");
        public bool IsBronze() => name.ToUpper().Equals("BRONZE MEDAL");
    }
}
