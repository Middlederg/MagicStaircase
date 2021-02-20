using MagicStaircase.Core;
using FluentAssertions;
using Xunit;
using System;

namespace MagicStaircase.Tests
{
    public class DescendingPileShould
    {
        public Pile Create() => new Pile(Direction.Down, 0);

        [Fact]
        public void Be_created()
        {
            var pile = Create();

            pile.LastCard.Should().Be(new Card(99));
            pile.ToString().Should().Be("99");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(8)]
        [InlineData(15)]
        [InlineData(80)]
        [InlineData(-4)]
        public void Add_card(int value)
        {
            var pile = Create();

            pile.Fits(new Card(value)).Should().BeTrue();

            pile.Add(new Card(value));

            pile.LastCard.Should().Be(new Card(value));
        }


        [Theory]
        [InlineData(100)]
        [InlineData(120)]
        [InlineData(84)]
        [InlineData(99)]
        [InlineData(80)]
        public void Fail_to_add_card(int value)
        {
            var pile = Create();

            pile.Add(new Card(80));

            pile.Fits(new Card(value)).Should().BeFalse();

            Action action = () => pile.Add(new Card(value));
            action.Should().Throw<Exception>();
        }

        [Fact]
        public void Add_5_cards()
        {
            var pile = Create();

            pile.Add(new Card(80));
            pile.Add(new Card(47));
            pile.Add(new Card(25));
            pile.Add(new Card(12));
            pile.Add(new Card(9));

            pile.ToString().Should().Be("99, 80, 47, 25, 12, 9");
        }

        [Fact]
        public void Add_10_more()
        {
            var pile = Create();

            pile.Add(new Card(76));

            pile.Fits(new Card(87)).Should().BeFalse();
            pile.Fits(new Card(86)).Should().BeTrue();
            pile.Fits(new Card(85)).Should().BeFalse();
            pile.Fits(new Card(77)).Should().BeFalse();
            pile.Fits(new Card(75)).Should().BeTrue();
        }
    }
}