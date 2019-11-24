namespace MagicStaircase.Core
{
    public class MinimunScoreStrategy : IUnlockingStrategy
    {
        private readonly int minimunScore;

        public MinimunScoreStrategy(int minimunScore)
        {
            this.minimunScore = minimunScore;
        }

        public bool IsUnlocked(Score score) => score.Points >= minimunScore;
    }
}
