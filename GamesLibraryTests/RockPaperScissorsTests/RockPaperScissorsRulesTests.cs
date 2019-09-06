using Xunit;
using GamesLibrary.RockPaperScissors;

namespace GamesLibraryTests.RockPaperScissorsTests
{
	public class RockPaperScissorsRulesTests
	{
        public RockPaperScissorsRules subject;

        public RockPaperScissorsRulesTests()
        {
            this.subject = new RockPaperScissorsRules();
        }

		[Theory]
		[InlineData(Weapon.Paper, Weapon.Paper)]
		[InlineData(Weapon.Rock, Weapon.Rock)]
		[InlineData(Weapon.Scissors, Weapon.Scissors)]
		public void WhenPlayerWeaponIsSameAsComputerWeapon_ItShouldReturnDraw(Weapon playerWeapon, Weapon computerWeapon)
		{
			var expected = Weapon.None;

			var result = subject.Fight(playerWeapon, computerWeapon);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void WhenRockFightsScissors_ItShouldReturnRock()
		{
			var expected = Weapon.Rock;

			var result = subject.Fight(Weapon.Rock, Weapon.Scissors);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void WhenPaperFightsScissors_ItShouldReturnScissors()
		{
			var expected = Weapon.Scissors;

			var result = subject.Fight(Weapon.Paper, Weapon.Scissors);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void WhenRockFightsPaper_ItShouldReturnPaper()
		{
			var expected = Weapon.Paper;

			var result = subject.Fight(Weapon.Rock, Weapon.Paper);

			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(Weapon.Rock)]
		[InlineData(Weapon.Paper)]
		[InlineData(Weapon.Scissors)]
		public void WhenNoneFightsAnything_ItShouldReturnAnything(Weapon computerWeapon)
		{
			var expected = computerWeapon;

			var result = subject.Fight(Weapon.None, computerWeapon);

			Assert.Equal(expected, result);
		}
	}
}
