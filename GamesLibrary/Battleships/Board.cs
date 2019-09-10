using System.Collections.Generic;
using System.Linq;

namespace GamesLibrary.Battleships
{
	public class Board
	{
		private List<Ship> fleet;
		public int Width => 10;
		public int Length => 10;
		public IEnumerable<Ship> Fleet => fleet;

		public Board()
		{
			fleet = new List<Ship>();
		}
		public void AddToFleet(Ship ship)
		{
			if(ValidatePosition(ship)) {
				fleet.Add(ship);
			} else {
				throw new InvalidShipLocationException();
			}
		}

		private bool ValidatePosition(Ship ship)
		{
			if( ship.Location.X < 1 ||
				ship.Location.X > this.Width ||
				ship.Location.Y < 1 ||
				ship.Location.Y > this.Length ) {
				return false;
			} else if (LocationAlreadyTaken(ship)) {
				return false;
			} else {
				return true;
			}
		}

		private bool LocationAlreadyTaken(Ship ship)
		{
			return fleet.Any( s =>
				s.Location.Y == ship.Location.Y &&
				s.Location.X == ship.Location.X
			);
		}
	}
}
