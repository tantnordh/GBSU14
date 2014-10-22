using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
	class Program
	{
		private static TicketManager _ticketManager = new TicketManager();
		private static List<int> _winningRow = CreateRandomRow.NewRow().Numbers;

		static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.White;
			int choice = -1;
			while (choice != 5)
			{
				ShowMenu();
				choice = choice.GetInput("Ditt val: ", 1, 5);
				HandleMenuChoice(choice);
			}
		}

		private static void HandleMenuChoice(int choice)
		{
			switch (choice)
			{
				case 1:
					int ticketNumber = _ticketManager.CreateTicket(_winningRow);
					Console.WriteLine("Din nya kupong har kupongnummer " + ticketNumber + ".");
					BackToMenu();
					break;

				case 2:
					_ticketManager.PrintTicket();
					BackToMenu();
					break;

				case 3:
					_ticketManager.PrintCheckedTicket(_winningRow);
					BackToMenu();
					break;

				case 4:
					_ticketManager.PrintAllTickets();
					BackToMenu();
					break;

				case 5:
					Environment.Exit(0);
					break;
			}
		}

		private static void BackToMenu()
		{
			Console.WriteLine();
			Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn.");
			Console.ReadKey();
		}

		private static void ShowMenu()
		{
			Console.Clear();
			string header = "meny";
			header.PrintHeader();
			Console.WriteLine("(1) Skapa kupong");
			Console.WriteLine("(2) Visa kupong");
			Console.WriteLine("(3) Rätta kupong");
			Console.WriteLine("(4) Skriv ut alla kuponger"); // fallande ordning baserat på antal rätt, vinnarkupong ska märkas extra tydligt
			Console.WriteLine("(5) Avsluta");
			Console.WriteLine();
		}
	}
}
