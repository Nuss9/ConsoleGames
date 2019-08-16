using Xunit;

namespace GamesLibrary
{
	public class RockPaperScissorsTests
	{
		[Theory]
		[InlineData(Weapon.Paper, Weapon.Paper)]
		[InlineData(Weapon.Rock, Weapon.Rock)]
		[InlineData(Weapon.Scissors, Weapon.Scissors)]
		public void WhenWeaponFightAgainstItself_ItShouldReturnNone(Weapon playerWeapon, Weapon computerWeapon)
		{
			RockPaperScissors game = new RockPaperScissors();
			var expected = Weapon.None;
			
			var result = game.Fight(playerWeapon, computerWeapon);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void WhenRockFightsScissors_ItShouldReturnRock()
		{
			RockPaperScissors game = new RockPaperScissors();
			var expected = Weapon.Rock;
			
			var result = game.Fight(Weapon.Rock, Weapon.Scissors);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void WhenPaperFightsScissors_ItShouldReturnScissors()
		{
			RockPaperScissors game = new RockPaperScissors();
			var expected = Weapon.Scissors;
			
			var result = game.Fight(Weapon.Paper, Weapon.Scissors);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void WhenRockFightsPaper_ItShouldReturnPaper()
		{
			RockPaperScissors game = new RockPaperScissors();
			var expected = Weapon.Paper;
			
			var result = game.Fight(Weapon.Rock, Weapon.Paper);

			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(Weapon.Rock)]
		[InlineData(Weapon.Paper)]
		[InlineData(Weapon.Scissors)]
		public void WhenNoneFightsAnything_ItShouldReturnAnything(Weapon computerWeapon)
		{
			RockPaperScissors game = new RockPaperScissors();
			var expected = computerWeapon;
			
			var result = game.Fight(Weapon.None, computerWeapon);

			Assert.Equal(expected, result);
		}
	}
}