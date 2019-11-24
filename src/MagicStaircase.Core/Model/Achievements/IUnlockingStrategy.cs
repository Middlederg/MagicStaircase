namespace MagicStaircase.Core
{
    public interface IUnlockingStrategy
    {
        bool IsUnlocked(Score score);
    }
}
