using System.Collections.Generic;

namespace GamesLibrary.Battleships
{
	public abstract class Ship
	{
		public abstract List<Point> Coordinates { get; set; }
		public abstract string Name { get; set; }
		public abstract bool IsAfloat { get; set; }
	}
}