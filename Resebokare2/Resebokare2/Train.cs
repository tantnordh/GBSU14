using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokare2
{
	public class Train
	{
		public Dictionary<int, Seat> Bookings { get; set; }

		public Train(int numberOfSeats)
		{
			Bookings = new Dictionary<int,Seat>();
			GenerateSeats(numberOfSeats);
		}

		private void GenerateSeats(int numberOfSeats)
		{
			for (int i = 1; i <= numberOfSeats; i++)
			{
				Seat temp = new Seat();
				Bookings.Add(i, temp);
			}
		}
	}
}
