using MagicStaircase.Core;
using System;
using Xunit;

namespace MagicStaircase.Tests
{
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
