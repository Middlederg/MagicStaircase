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

        public override string ToString() => name;

        public string Description() => $"To unlock this achievement, you must: {string.Join("\n-", unlockingStrategies)}";
    }
}
