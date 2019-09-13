using System.Collections.Generic;
using GamesLibrary.Battleships;
using Xunit;

namespace GamesLibraryTests.BattleShipTests
{
	public class BoardTests
	{
		public Board subject { get; set; }
		public Ship shipAtOneOne { get;}
		public Ship shipAtTwoTwo { get;}

		public BoardTests()
		{
			this.subject = new Board();
			this.shipAtOneOne = new Ship {Location = new List<Point> { new Point {X = 1, Y = 1}}};
			this.shipAtTwoTwo = new Ship {Location = new List<Point> { new Point {X = 2, Y = 2}}};
		}

		[Fact]
		public void WhenInstantiatingBoard_ItShouldBe10By10()
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
				Location = new List<Point> { new Point { X = x,	Y = y}}};

			Assert.Throws<InvalidShipLocationException>(() => subject.AddToFleet(ship));
		}

		[Fact]
		public void WhenPlacingAShipOnThePlayingboard_ItShouldBeAddedToTheFleet()
		{
			subject.AddToFleet(shipAtOneOne);

			Assert.Single(subject.Fleet);
		}

		[Fact]
		public void WhenPlacingASecondShipOnTheFirst_ItShouldThrow()
		{
			subject.AddToFleet(shipAtOneOne);

			Assert.Throws<InvalidShipLocationException>(() => subject.AddToFleet(shipAtOneOne));
		}

		[Fact]
		public void WhenASecondShipIsPlacedNearTheFirst_ItShouldThrow()
		{
			subject.AddToFleet(shipAtOneOne);

			Assert.Throws<InvalidShipLocationException>(() => subject.AddToFleet(shipAtTwoTwo));
		}
		
		[Fact]
		public void WhenPlacingAShipWithNonAdjecentPoints_ItShouldThrow()
		{
			Ship ship = new Ship {Location = new List<Point> {new Point { X = 1, Y = 1},  new Point { X = 3, Y = 1}}};
			
			Assert.Throws<InvalidShipLocationException>(() => subject.AddToFleet(ship));
		}
	}
}
