using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
	public class TicketManager
	{
		private static List<Ticket> _tickets;

		public List<Ticket> GetTickets()
		{
			return _tickets;
		}

		public int CreateTicket(List<int> winningNumbers)
		{
			PrintHeader("skapa kupong");
			int numberOfRows = 0;
			numberOfRows = numberOfRows.GetInput("Ange antal rader: ", "Ange ett heltal från 1 och uppåt.", 1);
			Ticket ticket = new Ticket(numberOfRows, _tickets.Count + 1);
			_tickets.Add(ticket);

			int numberCreation = 0;
			numberCreation = numberCreation.GetInput("(1) Slumpade rader\n(2) Ange egna rader", 1, 2);

			if (numberCreation == 1)
			{
				for (int i = 0; i < numberOfRows; i++)
				{
					ticket.Rows.Add(CreateRandomRow.NewRow());
					ticket.Rows[i].RowNumber = i + 1;
				}
			}
			else
			{
				Console.Write("Vinnarraden: ");
				for (int i = 0; i < winningNumbers.Count; i++)
				{
					Console.Write("\t" + winningNumbers[i]);
				}
				Console.WriteLine();

				for (int i = 0; i < numberOfRows; i++)
				{
					ticket.Rows.Add(new Row(new List<int> { 1, 1, 1, 1, 1 }));
					ticket.Rows[i].Numbers = ticket.Rows[i].GetRowNumberInput("Ange fem unika heltal 1-20, separera med komma: ", "Ange fem unika heltal mellan 1 och 20. Separera dina tal med kommatecken. Försök igen.");
					ticket.Rows[i].RowNumber = i + 1;
					ticket.Rows[i].Numbers = ticket.Rows[i].Numbers.OrderBy(n => n).ToList();
				}
			}

			CheckTicket(ticket, winningNumbers);

			return ticket.TicketNumber;
		}

		private void CheckTicket(Ticket ticket, List<int> winningNumbers)
		{
			int numberOfCorrectNumbers = 0;
			for (int i = 0; i < ticket.Rows.Count; i++)
			{
				for (int j = 0; j < ticket.Rows[i].Numbers.Count; j++)
				{
					if (winningNumbers.Contains(ticket.Rows[i].Numbers[j]))
					{
						numberOfCorrectNumbers++;
					}
				}
			}
			
			ticket.CorrectNumbersCount = numberOfCorrectNumbers;

			bool hasWinningRow = true;
			for (int i = 0; i < ticket.Rows.Count; i++)
			{
				for (int j = 0; j < ticket.Rows[i].Numbers.Count; j++)
				{
					if (!winningNumbers.Contains(ticket.Rows[i].Numbers[j]))
					{
						hasWinningRow = false;
						break;
					}

					if (!hasWinningRow)
					{
						break;
					}
				}
			}
			
			ticket.WinningTicket = hasWinningRow;
		}

		public void PrintTicket()
		{
			PrintHeader("visa kupong");
			Ticket chosenTicket = GetChosenTicket();
			chosenTicket.PrintTicket();
		}

		public void PrintAllTickets()
		{
			List<Ticket> sortedTickets = _tickets.OrderByDescending(t => t.CorrectNumbersCount).ToList();
			PrintHeader("alla kuponger");
			for (int i = 0; i < sortedTickets.Count; i++)
			{
				sortedTickets[i].PrintTicketSummary();
			}

			string info = "* Grön text = vinnarrad!";
			Console.WriteLine("_________________________________");
			Console.WriteLine();
			info.PrintWinner();
		}

		public void PrintCheckedTicket(List<int> winningNumbers)
		{
			PrintHeader("rätta kupong");
			Ticket chosenTicket = GetChosenTicket();
			chosenTicket.PrintCheckedTicket(winningNumbers);
		}

		private static Row GetChosenRow(Ticket chosenTicket)
		{
			int numberOfRowToEdit = 0;
			numberOfRowToEdit = numberOfRowToEdit.GetInput("Ange vilken rad du vill rätta: ", 1, chosenTicket.Rows.Count);
			return chosenTicket.Rows.Single(row => row.RowNumber == numberOfRowToEdit);
		}

		private static Ticket GetChosenTicket()
		{
			int input = 0;
			input = input.GetInput("Ange kupongnummer: ", 1, _tickets.Count);

			return _tickets.Single(t => t.TicketNumber == input);
		}

		private static void PrintHeader(string header)
		{
			Console.Clear();
			header.PrintHeader();
		}

		public TicketManager()
		{
			_tickets = new List<Ticket>();
		}
	}
}
