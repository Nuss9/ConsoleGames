using System;
using System.Threading;
using GamesLibrary;

namespace ConsoleInterface
{
	public class RockPaperScissorsMessenger
	{
		public void NewGame()
		{
			Console.WriteLine("                     Hello Player!");
            Console.WriteLine("           Let's play Rock-Paper-Scissors!");
			Console.WriteLine("");
			Console.WriteLine("    _______	         _______			    _______");
			Console.WriteLine("---'   ____)		---'    ____)____		---'   ____)____");
			Console.WriteLine("      (_____)		       ______)		          ______)");
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
            string input = string.Empty;
            bool keepPlaying = true;

            while (keepPlaying)
            {
                Console.WriteLine("Choose your weapon(r/p/s): ");
                input = Console.ReadLine();

                if(input == "quit")
                {
                    keepPlaying = false;
                    QuitGame();
                } else
                {
                    //SomethingLikeThis
                    var result = IGameMaster(Play(input));
                    DeclareWinner(result);
                }

            }
        }

        private void DeclareWinner(object result)
        {
            throw new NotImplementedException();
        }

        private void QuitGame()
        {
            throw new NotImplementedException();
        }
    }
}