using System;

namespace GamesLibrary.Battleships
{
	public class BoardInitializer
	{
		public Board Playingboard { get; set; }

		public BoardInitializer()
		{
			this.Playingboard = new Board();
		}
	}
}