using System;
using System.Collections.Generic;

namespace GamesLibrary.Battleships
{
	public class BoardInitializer
	{
		public int BoardWidth { get; set; }
		public int BoardLength { get; set; }
		public List<Ship> Fleet { get; set; }

		public BoardInitializer()
		{
			this.BoardLength = 5;
			this.BoardWidth = 5;
			this.Fleet = new List<Ship>();
		}

		public void PlaceSubmarine()
		{
			var submarineLocation = GetRandomPoint();
			Submarine boat = new Submarine();
			boat.Coordinates.Add(submarineLocation);
			this.Fleet.Add(boat);
		}

		private Point GetRandomPoint()
		{
			Random random = new Random();
			int xCoordinate = random.Next(1, this.BoardWidth);
			int yCoordinate = random.Next(1, this.BoardLength);

			return  new Point {
				XCoordinate = xCoordinate,
				YCoordinate = yCoordinate
			};
		}
	}
}