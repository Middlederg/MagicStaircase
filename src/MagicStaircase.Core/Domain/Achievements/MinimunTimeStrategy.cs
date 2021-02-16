namespace MagicStaircase.Core
{
    public class MinimunTimeStrategy : IUnlockingStrategy
    {
        private readonly Time minimumTime;

        public MinimunTimeStrategy(Time minimumTime)
        {
            this.minimumTime = minimumTime;
        }

        public bool IsUnlocked(Score score) => score.Time.IsLowerThan(minimumTime);

        public override string ToString() => $"End a game in less than {minimumTime.ToText()}.";
    }
}
