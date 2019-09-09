using System.Collections.Generic;

namespace GamesLibrary.Battleships
{
	public class Submarine : Ship
	{
		public override List<Point> Coordinates { get; set; }
		public override string Name { get; set; }
		public override bool IsAfloat { get; set; }

		public Submarine()
		{
			this.Coordinates = new List<Point>();
			this.IsAfloat = true;
		}
	}
}