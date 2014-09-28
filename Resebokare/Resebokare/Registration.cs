using System;

namespace ReseBokare
{
	public abstract class Registration
	{
		public abstract Passenger CreatePassenger();
		public abstract Passenger[] List();
		public abstract int ListCounter();
		public abstract void DecrementListCounter();

		public void PassengerRegistration()
		{
			Passenger temp = CreatePassenger();

			Console.WriteLine("Specificera stolsnummer(1) eller slumpa(2): ");
			string specificOrRandomSeatNumber = Console.ReadLine();
			while (specificOrRandomSeatNumber != "1" && specificOrRandomSeatNumber != "2")
			{
				Console.WriteLine("Ange ditt val som ett heltal 1-2:");
				specificOrRandomSeatNumber = Console.ReadLine();
			}

			if (specificOrRandomSeatNumber == "1")
			{
				Console.WriteLine("Ange önskat stolsnummer 1-" + List().Length + ": ");
				int prefSeatNumber;
				while (!int.TryParse(Console.ReadLine(), out prefSeatNumber) || prefSeatNumber < 1 || prefSeatNumber > List().Length)
				{
					Console.WriteLine("Försök med ett heltal 1-" + List().Length + ":");
				}
				bool seatAvailable = CheckAvailability(prefSeatNumber - 1, List());
				if (seatAvailable)
				{
					List()[prefSeatNumber - 1] = temp;
				}
				else
				{
					int assignedSeat = AssignEmptySeat(List());
					List()[assignedSeat] = temp;
					Console.WriteLine("Stolsnumret du har önskat är upptaget och du har fått stolsnummer " + (assignedSeat + 1) + " istället.");
				}
			}
			else
			{
				int assignedSeat = AssignEmptySeat(List());
				List()[assignedSeat] = temp;
			}

			DecrementListCounter();
		}

		private static int AssignEmptySeat(Passenger[] list)
		{
			Random random = new Random();
			int seat = list.Length;
			do
			{
				seat = random.Next(0, list.Length);
			} while (list[seat] != null);

			return seat;
		}

		private static bool CheckAvailability(int seatToCheck, Passenger[] list)
		{
			if (list[seatToCheck] == null)
			{
				return true;
			}

			return false;
		}
	}
}
