namespace GamesLibrary.Battleships
{
	public class BoardInitializer
	{
		public Board Playingboard { get; set; }

		public BoardInitializer()
		{
			this.Playingboard = new Board();
		}

		public void AddToPlayingboard (Ship ship)
		{
			this.Playingboard.AddToFleet(ship);
		}
	}
}