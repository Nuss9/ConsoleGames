using System;
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
			if(IsShipLocationIfOffTheBoard(ship) ) {
				return false;
			} else if (LocationAlreadyTaken(ship)) {
				return false;
			} else if (LocationIsInProximityOfExistingLocations(ship)) {
				return false;
			} else {
				return true;
			}
		}

		public bool IsShipLocationIfOffTheBoard(Ship ship)
		{
				return ship.Location.X < 1 ||
					ship.Location.X > this.Width ||
					ship.Location.Y < 1 ||
					ship.Location.Y > this.Length;
		}

		private bool LocationAlreadyTaken(Ship newShip)
		{
			return fleet.Any( ship =>
				ship.Location.Y == newShip.Location.Y &&
				ship.Location.X == newShip.Location.X
			);
		}

		private bool LocationIsInProximityOfExistingLocations(Ship newShip)
		{
			List<Point> proximityCoordinates = new List<Point>();
			List<Point> shipLocations = new List<Point>();

			if(fleet.Count != 0){
				foreach(Ship ship in Fleet) {
					shipLocations.Add(ship.Location);
				}

				foreach(Point coordinate in shipLocations) {
					proximityCoordinates.Add(new Point {X = coordinate.X, 		Y = coordinate.Y + 1});
					proximityCoordinates.Add(new Point {X = coordinate.X + 1, 	Y = coordinate.Y + 1});
					proximityCoordinates.Add(new Point {X = coordinate.X + 1, 	Y = coordinate.Y});
					proximityCoordinates.Add(new Point {X = coordinate.X + 1, 	Y = coordinate.Y - 1});
					proximityCoordinates.Add(new Point {X = coordinate.X, 		Y = coordinate.Y - 1});
					proximityCoordinates.Add(new Point {X = coordinate.X -1, 	Y = coordinate.Y - 1});
					proximityCoordinates.Add(new Point {X = coordinate.X - 1, 	Y = coordinate.Y});
					proximityCoordinates.Add(new Point {X = coordinate.X -1, 	Y = coordinate.Y + 1});
				}
		
				IEnumerable<Point> uniqueProximityCoordinates = proximityCoordinates.Distinct();

				if(uniqueProximityCoordinates.Contains(newShip.Location)) {
					return true;
				}
			}
		
			return false;
		}
	}
}
