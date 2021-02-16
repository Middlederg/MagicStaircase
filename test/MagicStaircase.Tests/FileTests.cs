using MagicStaircase.Core;
using MagicStaircase.Core.Repositories;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace MagicStaircase.Tests
{
    public class FileTests
    {
        private readonly LocalFileScoreRepository repository;

        public FileTests()
        {
            repository = new LocalFileScoreRepository();
        }

        [Fact]
        public async Task Should_add_one_score()
        {
            await repository.AddScore(new Score(TestFactory.AnyPlayer, 50, TestFactory.AnyTime));
            var scores = (await repository.GetScores()).ToList();

            Assert.Contains(scores, x => x.Player.Equals(TestFactory.AnyPlayer));
            Assert.Contains(scores, x => x.Points.Equals(50));
            Assert.Contains(scores, x => x.Time.Equals(TestFactory.AnyTime));
        }
    }
}
