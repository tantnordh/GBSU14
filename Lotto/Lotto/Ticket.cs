using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
	public class Ticket
	{
		public List<Row> Rows { get; set; }
		public int TicketNumber { get; private set; }
		public int CorrectNumbersCount { get; set; }
		public bool WinningTicket { get; set; }

		public Ticket(int numberOfRows, int ticketNumber)
		{
			TicketNumber = ticketNumber;
			Rows = new List<Row>(numberOfRows);
			WinningTicket = false;
		}
	}
}
