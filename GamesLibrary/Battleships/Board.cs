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
			foreach(Point coordinate in ship.Location) {
				if(coordinate.X < 1 ||
					coordinate.X > this.Width ||
					coordinate.Y > 10 ||
					coordinate.Y > this.Length) {
					return true;
				}
			}

			return false;
		}

		private bool LocationAlreadyTaken(Ship newShip)
		{
			return fleet.Any( ship =>
				ship.Location == newShip.Location &&
				ship.Location == newShip.Location
			);
		}

		private bool LocationIsInProximityOfExistingLocations(Ship newShip)
		{
			IEnumerable<Point> proximityCoordinates = new List<Point>();
			List<Point> shipLocations = new List<Point>();

			if(fleet.Count != 0){
				foreach(Ship ship in Fleet) {
					foreach(Point coordinate in ship.Location){
						shipLocations.Add(coordinate);
					}
				}

				foreach(Point coordinate in shipLocations) {
					proximityCoordinates = GetPointsInProximity(coordinate);
				}
		
				foreach(Point coordinate in proximityCoordinates) {
					if(newShip.Location.Contains(coordinate)) {
						return true;
					}
				}
			}
		
			return false;
		}

		private IEnumerable<Point> GetPointsInProximity(Point coordinate)
		{
			List<Point> proximityCoordinates = new List<Point>();

			proximityCoordinates.Add(new Point {X = coordinate.X, 		Y = coordinate.Y + 1});
			proximityCoordinates.Add(new Point {X = coordinate.X + 1, 	Y = coordinate.Y + 1});
			proximityCoordinates.Add(new Point {X = coordinate.X + 1, 	Y = coordinate.Y});
			proximityCoordinates.Add(new Point {X = coordinate.X + 1, 	Y = coordinate.Y - 1});
			proximityCoordinates.Add(new Point {X = coordinate.X, 		Y = coordinate.Y - 1});
			proximityCoordinates.Add(new Point {X = coordinate.X -1, 	Y = coordinate.Y - 1});
			proximityCoordinates.Add(new Point {X = coordinate.X - 1, 	Y = coordinate.Y});
			proximityCoordinates.Add(new Point {X = coordinate.X -1, 	Y = coordinate.Y + 1});
			
			return proximityCoordinates.Distinct();
		}
	}
}
