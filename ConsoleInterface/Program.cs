using System;
using GamesLibrary;

namespace ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
			Menus.MainMenu();
            while(true){
                string choice = Menus.MenuChoice();
                Console.Clear();
                if(choice == "1") {
                    var gameMessenger = new RockPaperScissorsMessenger();
                    gameMessenger.Play();
                }
            }
        }
    }
}
