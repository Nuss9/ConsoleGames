using GamesLibrary.RockPaperScissors;

namespace GamesLibrary
{
	public class RockPaperScissorsRules
	{
		public Weapon Fight(Weapon playerWeapon, Weapon computerWeapon)
		{
            if (playerWeapon == Weapon.None) {
                return computerWeapon;
            }

            if (playerWeapon == computerWeapon) {
                return Weapon.None;
            }

            if (playerWeapon == Weapon.Rock) {
                if (computerWeapon == Weapon.Paper) {
                    return Weapon.Paper;
                } else {
                    return Weapon.Rock;
                }
            }

            if (playerWeapon == Weapon.Paper)
            {
                if (computerWeapon == Weapon.Rock)
                {
                    return Weapon.Paper;
                }
                else
                {
                    return Weapon.Scissors;
                }
            }

            if (playerWeapon == Weapon.Scissors)
            {
                if (computerWeapon == Weapon.Paper)
                {
                    return Weapon.Scissors;
                }
                else
                {
                    return Weapon.Rock;
                }
            }

            // Should not be reached
            return Weapon.None;
		}
	}
}