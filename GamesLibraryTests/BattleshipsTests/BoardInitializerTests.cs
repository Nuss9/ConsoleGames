using GamesLibrary.Battleships;
using Xunit;

namespace GamesLibraryTests.BattleShipTests
{
	public class BoardInitializerTests
	{
		public BoardInitializer subject { get; set; }

		public BoardInitializerTests()
		{
			this.subject = new BoardInitializer();
		}

		[Fact]
		public void WhenInitializingGame_ItShouldSetDefaultBoundaries()
		{
			int expected = 5;

			Assert.Equal(expected, subject.BoardWidth);
			Assert.Equal(expected, subject.BoardLength);
		}

		[Fact]
		public void When_ItShould()
		{
			
		}
	}
}