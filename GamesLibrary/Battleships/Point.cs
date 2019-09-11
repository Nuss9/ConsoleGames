using System;

namespace GamesLibrary.Battleships
{
	public class Point : IEquatable<Point>
	{
		public int X { get; set; }
		public int Y { get; set; }

		public bool Equals (Point other)
		{
			if ( this.X == other.X && this.Y == other.Y ) {
				return true;
			} else {
				return false;
			}
		}
	}
}