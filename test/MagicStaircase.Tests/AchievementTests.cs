using MagicStaircase.Core;
using MagicStaircase.Core.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace MagicStaircase.Tests
{
    public class FileTests
    {
        [Fact]
        public async Task Should_add_one_score()
        {
            await ScoreRepository.AddScore(TestFactory.AnyPlayer, 50, TestFactory.AnyTime);
            var scores = (await ScoreRepository.GetScores()).ToList();

            Assert.Contains(scores, x => x.Player.Equals(TestFactory.AnyPlayer));
            Assert.Contains(scores, x => x.Points.Equals(50));
            Assert.Contains(scores, x => x.Time.Equals(TestFactory.AnyTime));
        }
    }

    public static class TestFactory
    {
        public static Player AnyPlayer = new Player("Any player");
        public static Time AnyTime = new Time(545122);
    }
    public class AchievementTests
    {
       

        [Fact]
        public void Should_unlock_the_achievement()
        {
            var achievement = AchievementFactory.GoldMedal;
            var score = new Score(TestFactory.AnyPlayer, 100,TestFactory.AnyTime);

            var result = achievement.AchievementUnlocked(score);

            Assert.True(result);
        }

        [Fact]
        public void Should_not_unlock_the_achievement()
        {
            var achievement = AchievementFactory.GoldMedal;
            var score = new Score(TestFactory.AnyPlayer, 96, TestFactory.AnyTime);

            var result = achievement.AchievementUnlocked(score);

            Assert.False(result);
        }
    }
}
