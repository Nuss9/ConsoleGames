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

		[Fact]
		public void WhenPlacingAShipOffThePlayingboard_ItShouldThrow()
		{
			Submarine ship = new Submarine {
				Location = new Point {
					X = 0,
					Y = 0
				}
			};

			Assert.Throws<InvalidShipLocationException>(() => subject.AddToFleet(ship));
		}

		[Fact]
		public void WhenPlacingAShipLocationIsValid_ItShouldBeAddedToTheFleet()
		{
			Submarine ship = new Submarine {
				Location = new Point {
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
			Submarine ship = new Submarine {
				Location = new Point {
					X = 1,
					Y = 1
				}
			};

			subject.AddToFleet(ship);
			
			Assert.Throws<InvalidShipLocationException>(() => subject.AddToFleet(ship));
		}
	}
}