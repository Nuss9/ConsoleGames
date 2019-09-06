using GamesLibrary.RockPaperScissors;

namespace GamesLibrary
{
	public interface IRockPaperScissorsGame
	{
		GameResult Play(string input);

		(int playerScore, int computerScore) GetScore();
	}
}