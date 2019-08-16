using System;
using System.Threading;

namespace ConsoleInterface
{
	public static class Menus
	{
		public static void MainMenu()
		{
			Console.WriteLine("       .-------.    ______");
			Console.WriteLine("      /   o   /|   /\\     \\");
			Console.WriteLine("     /_______/o|  /o \\  o  \\");
			Console.WriteLine("     | o     | | /   o\\_____\\");
			Console.WriteLine("     |   o   |o/ \\o   /o    /");
			Console.WriteLine("     |     o |/   \\ o/  o  /");
			Console.WriteLine("     '-------'     \\/____o/");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("      W E L C O M E   T O");
			Console.WriteLine("    C O N S O L E   G A M E S");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("* * * * * * * * * * * * * * * * * *");
			Console.WriteLine("");
		}
		
		public static string MenuChoice()
		{
			Console.WriteLine("Please choose one of the following games:");
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine(" 1 - Rock Paper Scissors");
			Console.WriteLine(" 2 - Coming soon!");
			Console.WriteLine(" 3 - Coming soon!");
			
			return Console.ReadLine();
		}

		public static void UnclearChoice()
		{
			Console.WriteLine("");
			Console.Write("Unclear instructions.");
			Thread.Sleep(1000);
			Console.Write(" Please try again.");		
		}
	}
}
