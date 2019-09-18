using System.Collections.Generic;

namespace GamesLibrary.Battleships
{
	public class Destroyer : Ship
	{
		public Destroyer(List<Point> location)
		{
			this.Location = location;
		}
	}
}
