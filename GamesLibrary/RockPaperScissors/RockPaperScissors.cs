using System;

namespace GamesLibrary
{
	public class RockPaperScissors
	{
		public Weapon Fight(Weapon weaponPlayer, Weapon weaponComputer)
		{
			if(weaponPlayer == Weapon.Rock && weaponComputer == Weapon.Scissors) {
				return Weapon.Rock;
			} else if (weaponPlayer == Weapon.Paper && weaponComputer == Weapon.Scissors) {
				return Weapon.Scissors;
			} else if (weaponPlayer == Weapon.Rock && weaponComputer == Weapon.Paper) {
				return Weapon.Paper;
			} else {
				return Weapon.None;
			}
		}
	}
}