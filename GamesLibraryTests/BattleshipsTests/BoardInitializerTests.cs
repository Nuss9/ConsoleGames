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
		public void WhenASubmarineIsPlaced_ItShouldOccupyOneCoordinateOnThePlayingboard()
		{
			subject.PlaceSubmarine();

			Assert.Single<Point>(subject.Fleet[0].Coordinates);
			Assert.InRange(subject.Fleet[0].Coordinates[0].XCoordinate, 1, subject.BoardWidth);
			Assert.InRange(subject.Fleet[0].Coordinates[0].YCoordinate, 1, subject.BoardLength);
		}
	}
}