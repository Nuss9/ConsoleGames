using System.Collections.Generic;

namespace GamesLibrary.Battleships
{
	public class Destroyer : Ship
	{
		private new List<Point> Location;

		public Destroyer(List<Point> location)
		{
			this.Location = location;
		}
	}
}
