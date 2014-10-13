using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokare2
{
	public abstract class Registration
	{
		public Seat AssignedSeat { get; set; }
		public Seat[] Seats { get; private set; }
		public List<FirstClassRegistration> Registry { get; private set; }
		public abstract Passenger NewPassenger { get; set; }
		public abstract void CreatePassenger();

		public void AssignSeat()
		{
			Console.WriteLine("Ange önskat platsnummer eller lämna fältet tomt för slumpat platsnummer:  ");
			int prefSeat = int.Parse(Console.ReadLine());
			if ()
			{
				AssignedSeat = new Seat(prefSeat);
			}
		}
		
		public Registration(Train train, Passenger passenger)
		{
			Seats = seats;
			Registry = registry;
		}
	}
}
