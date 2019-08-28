using System;
using GamesLibrary.RockPaperScissors;

namespace GamesLibrary
{
	public class GameMaster : IRockPaperScissorsGame
	{
		public GameResult Play(string input)
		{
			Weapon computerWeapon = GetRandomWeapon();
			Weapon playerWeapon;

			switch(input.ToLower()){
				case "r":
				case "rock":
					playerWeapon = Weapon.Rock;
					break;
				case "p":
				case "paper":
					playerWeapon = Weapon.Paper;
					break;
				case "s":
				case "scissors":
					playerWeapon = Weapon.Scissors;
					break;
				default:
					playerWeapon = Weapon.None;
					break;
			}

			RockPaperScissorsRules game = new RockPaperScissorsRules();

			var winningWeapon = game.Fight(playerWeapon, computerWeapon);

            if(winningWeapon == Weapon.None)
            {
                return GameResult.Draw;
            } else if(winningWeapon == computerWeapon)
            {
                return GameResult.Lose;
            } else
            {
                return GameResult.Win;
            }
		}

		private Weapon GetRandomWeapon()
		{
			Random randomizer = new Random();
			int weaponNumber = randomizer.Next(0,3);
			return (Weapon)Enum.Parse(typeof(Weapon), weaponNumber.ToString());
		}
	}
}