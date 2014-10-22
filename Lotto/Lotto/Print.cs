using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
	public static class Print
	{
		public static void PrintHeader(this string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(text.ToUpper());
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine();
		}

		public static void PrintInstruction(this string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.DarkGray;
		}

		public static void PrintCorrectNumber(this int number)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\t" + number);
			Console.ForegroundColor = ConsoleColor.DarkGray;
		}

		public static void PrintIncorrectNumber(this int number)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("\t" + number);
			Console.ForegroundColor = ConsoleColor.DarkGray;
		}

		public static void PrintWinner(this string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.DarkGray;
		}

		public static void PrintCheckedTicket(this Ticket ticket, List<int> winningNumbers)
		{
			Console.WriteLine("Kupongnummer " + ticket.TicketNumber);
			List<Row> rows = ticket.Rows;
			for (int i = 0; i < rows.Count; i++)
			{
				Console.Write((i + 1) + ": ");
				for (int j = 0; j < rows[i].Numbers.Count; j++)
				{
					if (winningNumbers.Contains(rows[i].Numbers[j]))
					{
						rows[i].Numbers[j].PrintCorrectNumber();
					}
					else
					{
						rows[i].Numbers[j].PrintIncorrectNumber();
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		public static void PrintTicket(this Ticket ticket)
		{
			List<Row> rows = ticket.Rows;
			Console.WriteLine("Kupongnummer " + ticket.TicketNumber);

			for (int i = 0; i < rows.Count; i++ )
			{
				Console.Write((i + 1) + ": ");
				for (int j = 0; j < rows[i].Numbers.Count; j++)
				{
					Console.Write("\t" + rows[i].Numbers[j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		public static void PrintTicketSummary(this Ticket ticket)
		{
			string text = "Kupongnummer " + ticket.TicketNumber + ": " + ticket.CorrectNumbersCount + " rätt.";
			if (ticket.WinningTicket)
			{
				text.PrintWinner();
			}
			else
			{
				Console.WriteLine(text);
			}
			
			Console.WriteLine();
		}
	}
}
