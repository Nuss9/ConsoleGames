namespace GamesLibrary.Battleships
{
	public class BoardInitializer
	{
		public Board Playingboard { get; set; }

		public BoardInitializer()
		{
			Playingboard = new Board();
		}

		public void AddToPlayingboard (Ship ship)
		{
			Playingboard.AddToFleet(ship);
		}
	}
}