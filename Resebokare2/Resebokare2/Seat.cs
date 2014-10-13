using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokare2
{
	public class Seat
	{
		public Passenger Passenger { get; set; }

		public void Print()
		{
			Console.WriteLine("Namn: " + Passenger.Name);
			Console.WriteLine("Syfte: " + Passenger.Objective);
			if (Passenger.GetType() == typeof(PassengerFirst))
			{
				Console.WriteLine("Sleeper: " + Passenger.Extra);
			}
			else if (Passenger.GetType() == typeof(PassengerEconomy))
			{
				Console.WriteLine("Lunch: " + Passenger.Extra);
			}
		}
	}
}