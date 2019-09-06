using System;
using GamesLibrary.RockPaperScissors;

namespace GamesLibrary
{
	public class GameMaster : IRockPaperScissorsGame
	{
		private int PlayerScore { get; set; }
		private int ComputerScore { get; set; }

		public GameResult Play(string input)
		{
			Weapon computerWeapon = GetRandomWeapon();
			Weapon playerWeapon = ConvertToWeapon(input);

			RockPaperScissorsRules game = new RockPaperScissorsRules();

			var winningWeapon = game.Fight(playerWeapon, computerWeapon);

            if(winningWeapon == Weapon.None)  {
                return GameResult.Draw;
            } else if(winningWeapon == computerWeapon) {
				ComputerScore++;
                return GameResult.Lose;
            } else {
				PlayerScore++;
                return GameResult.Win;
            }
		}
		
		public (int, int) GetScore()
		{
			return (PlayerScore, ComputerScore);
		}

		private Weapon ConvertToWeapon(string input)
		{
			Weapon result;

			switch(input.ToLower()){
				case "r":
				case "rock":
					result = Weapon.Rock;
					break;
				case "p":
				case "paper":
					result = Weapon.Paper;
					break;
				case "s":
				case "scissors":
					result = Weapon.Scissors;
					break;
				default:
					result = Weapon.None;
					break;
			}

			return result;
		}

		private Weapon GetRandomWeapon()
		{
			Random randomizer = new Random();
			int weaponNumber = randomizer.Next(0,3);
			return (Weapon)Enum.Parse(typeof(Weapon), weaponNumber.ToString());
		}
	}
}