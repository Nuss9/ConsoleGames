using System;
using GamesLibrary;

namespace GamesLibrary.RockPaperScissors
{
    public class GameMaster : IGameMaster
    {
        public GameMaster()
        {
            RockPaperScissors game = new RockPaperScissors();
        }

        public GameResult Play(string input)
        {
            switch (input.ToLower())
            {
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

            Random randomizer = new Random();
            int weaponNumber = randomizer.Next(1, 3);
            Weapon computerWeapon = (Weapon)Enum.Parse(typeof(Weapon), weaponNumber.ToString());

            var winner = game.Fight(playerWeapon, computerWeapon);

            return GameResult.Draw;
        }
    }
}
