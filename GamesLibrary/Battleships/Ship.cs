using System.Collections.Generic;

namespace GamesLibrary.Battleships
{
	public abstract class Ship
	{
		private readonly List<Point> location = new List<Point>();

		protected Ship(IEnumerable<Point> location)
		{
			this.location.AddRange(location);
		}

		public IEnumerable<Point> Location => location;
	}
}
