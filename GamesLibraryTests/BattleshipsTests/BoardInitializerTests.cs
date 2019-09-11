using GamesLibrary.Battleships;
using Xunit;

namespace GamesLibraryTests.BattleShipTests
{
	public class BoardTests
	{
		public Board subject { get; set; }

		public BoardTests()
		{
			this.subject = new Board();
		}

		[Fact]
		public void WhenInstantiating_ItShouldCreateA10By10Board()
		{
			int expected = 10;

			Assert.Equal(expected, this.subject.Width);
			Assert.Equal(expected, this.subject.Length);
		}

		[Theory]
		[InlineData(0, 0)]
		[InlineData(0, 11)]
		[InlineData(11, 0)]
		[InlineData(11, 11)]
		public void WhenPlacingAShipOffThePlayingboard_ItShouldThrow(int x, int y)
		{
			Ship ship = new Ship
			{
				Location = new Point
				{
					X = x,
					Y = y
				}
			};

			Assert.Throws<InvalidShipLocationException>(() => subject.AddToFleet(ship));
		}

		[Fact]
		public void WhenPlacingAShipOnThePlayingboard_ItShouldBeAddedToTheFleet()
		{
			Ship ship = new Ship
			{
				Location = new Point
				{
					X = 1,
					Y = 1
				}
			};

			subject.AddToFleet(ship);

			Assert.Single(subject.Fleet);
		}

		[Fact]
		public void WhenPlacingASecondShipOnTheFirst_ItShouldThrow()
		{
			Ship ship = new Ship
			{
				Location = new Point
				{
					X = 1,
					Y = 1
				}
			};

			subject.AddToFleet(ship);

			Assert.Throws<InvalidShipLocationException>(() => subject.AddToFleet(ship));
		}

		[Fact]
		public void WhenASecondShipIsPlacedNearTheFirst_ItShouldThrow()
		{
			Ship ship1 = new Ship
			{
				Location = new Point
				{
					X = 1,
					Y = 1
				}
			};

			subject.AddToFleet(ship1);

			Ship ship2 = new Ship
			{
				Location = new Point
				{
					X = 2,
					Y = 2
				}
			};

			Assert.Throws<InvalidShipLocationException>(() => subject.AddToFleet(ship2));
		}
	}
}
