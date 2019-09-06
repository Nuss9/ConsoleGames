using System;
using GamesLibrary.RockPaperScissors;

namespace GamesLibrary
{
	public class GameMaster : IRockPaperScissorsGame
	{
		public GameResult Play(string input)
		{
			Weapon computerWeapon = GetRandomWeapon();
			Weapon playerWeapon = ConvertToWeapon(input);

			RockPaperScissorsRules game = new RockPaperScissorsRules();

			var winningWeapon = game.Fight(playerWeapon, computerWeapon);

            if(winningWeapon == Weapon.None)  {
                return GameResult.Draw;
            } else if(winningWeapon == computerWeapon) {
                return GameResult.Lose;
            } else {
                return GameResult.Win;
            }
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