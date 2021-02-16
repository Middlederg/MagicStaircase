using MagicStaircase.Core;
using FluentAssertions;
using Xunit;
using System;

namespace MagicStaircase.Tests
{
    public class AscendingPileShould
    {
        private readonly Pile pile;

        public AscendingPileShould()
        {
            pile = new Pile(Direction.Up);
        }

        [Fact]
        public void Be_created()
        {
            pile.LastCard.Should().Be(new Card(1));
            pile.ToString().Should().Be("1");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(8)]
        [InlineData(15)]
        [InlineData(80)]
        [InlineData(120)]
        public void Add_card(int value)
        {
            pile.Fits(new Card(value)).Should().BeTrue();

            pile.Add(new Card(value));

            pile.LastCard.Should().Be(new Card(value));

            pile.ToString().Should().Be($"{1}, {value}");
        }


        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(14)]
        public void Fail_to_add_card(int value)
        {
            pile.Add(new Card(14));

            pile.Fits(new Card(value)).Should().BeFalse();

            Action action = () => pile.Add(new Card(value));
            action.Should().Throw<Exception>();
        }

        [Fact]
        public void Add_5_cards()
        {
            pile.Add(new Card(9));
            pile.Add(new Card(12));
            pile.Add(new Card(25));
            pile.Add(new Card(47));
            pile.Add(new Card(48));

            pile.ToString().Should().Be("1, 9, 12, 25, 47, 48");
        }

        [Fact]
        public void Add_10_less()
        {
            pile.Add(new Card(31));

            pile.Fits(new Card(20)).Should().BeFalse();
            pile.Fits(new Card(21)).Should().BeTrue();
            pile.Fits(new Card(22)).Should().BeFalse();
            pile.Fits(new Card(32)).Should().BeTrue();
        }
    }
}