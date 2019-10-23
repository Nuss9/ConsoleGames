namespace GamesLibrary.Battleships
{
	public class BoardMaker
	{
		public int BoardWidth { get { return 10; } }
		public int BoardHeight { get { return 10; } }

		public PlayingBoard Execute()
		{
			return new PlayingBoard();
		}
	}
}