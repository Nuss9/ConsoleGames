using System;
using System.Threading;
using GamesLibrary;
using GamesLibrary.RockPaperScissors;

namespace ConsoleInterface
{
	public class RockPaperScissorsMessenger
	{
        public RockPaperScissorsMessenger()
        {
			Console.WriteLine("                     Hello Player!");
            Console.WriteLine("           Let's play Rock-Paper-Scissors!");
			Console.WriteLine("");
			Console.WriteLine("    _______	         _______			    _______");
			Console.WriteLine("---'   ____)		---'    ____)____		---'   ____)____");
			Console.WriteLine("      (_____)               ______)                ______)");
			Console.WriteLine("      (_____)		      _______)		       __________)");
			Console.WriteLine("      (____)		         _______)		      (____)");
			Console.WriteLine("---.__(___)		---.__________)			---.__(___)");
			Console.WriteLine("");
			Console.WriteLine("");
			Thread.Sleep(1000);
			Console.WriteLine("       Enter 'quit' to return to the Main Menu.");
			Console.WriteLine("");
			Console.WriteLine("");
			Thread.Sleep(2000);
        }

        public void Play()
        {
            string input;
            bool keepPlaying = true;
			IRockPaperScissorsGame gameMaster = new GameMaster();

            while (keepPlaying)
            {
                Console.WriteLine("Choose your weapon(r/p/s): ");
                input = Console.ReadLine();

                if(input == "quit" || input == "q")
                {
                    keepPlaying = false;
                    QuitGame();
                } else
                {
                    var result = gameMaster.Play(input);
                    DeclareWinner(result);
                }
            }
        }

        private void DeclareWinner(object result)
        {
            switch (result.ToString())
            {
                case "Win":
                    Console.WriteLine("Congratulations! You won!");
                    break;
                case "Lose":
                    Console.WriteLine("Unfortunately you lose!");
                    break;
                case "Draw":
                    Console.WriteLine("A draw!");
                    break;
                default:
                    Console.WriteLine("Please contact your administrator.");
                    break;
            }
        }

        private void QuitGame()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Quitting game");
            Thread.Sleep(400);
            Console.WriteLine(".");
            Thread.Sleep(400);
            Console.WriteLine(".");
            Thread.Sleep(400);
            Console.WriteLine(".");
            Thread.Sleep(400);
            Console.Clear();
        }
    }
}