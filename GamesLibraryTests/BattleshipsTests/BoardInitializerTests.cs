using System;
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
		public void WhenInstantiating_ItShouldCreateA10By10Board()
		{
			int expected = 10;

			Assert.Equal(expected, this.subject.Playingboard.Width);
			Assert.Equal(expected, this.subject.Playingboard.Length);
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

			Assert.Throws<InvalidShipLocationException>(() => subject.AddToPlayingboard(ship));
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

			subject.AddToPlayingboard(ship);

			Assert.Single(subject.Playingboard.Fleet);
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

			subject.AddToPlayingboard(ship);
			
			Assert.Throws<InvalidShipLocationException>(() => subject.AddToPlayingboard(ship));
		}
	}
}