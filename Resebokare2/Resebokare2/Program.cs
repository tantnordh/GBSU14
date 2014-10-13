using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokare2
{
	public class Program
	{
		private static Train _train = new Train(100);

		static void Main(string[] args)
		{
			bool run = true;
			while (run)
			{
				int choice = Menu();
				if (choice != 6)
				{
					HandleChoice(choice);
					Console.WriteLine("\nTryck retur för att återgå till menyn.");
					Console.ReadLine();
					Console.Clear();
				}
				else
				{
					run = false;
				}
			}
		}

		private static int Menu()
		{
			//Console.WriteLine("Antal lediga platser i Första klass är " + _firstClass.ListCounter() + " och i ekonomiklass " + _economyClass.ListCounter());
			Console.WriteLine("\nVälj ett av följande alternativ, ange ditt val som ett heltal:");
			Console.WriteLine("1. Registrera ny passagerare till första klass");
			Console.WriteLine("2. Registrera ny passagerare till ekonomiklass");
			Console.WriteLine("3. Visa passagerare som reser med första klass");
			Console.WriteLine("4. Visa passagerare som reser med ekonomiklass");
			Console.WriteLine("5. Visa alla passagerare");
			Console.WriteLine("6. Avsluta");

			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
			{
				Console.WriteLine("Försök med ett heltal 1-6: ");
			}

			return choice;
		}

		private static void HandleChoice(int choice)
		{
			if (choice == 1)
			{
				BookFirstClass();
			}
			else if (choice == 2)
			{
				BookEconomyClass();
			}
			else if (choice == 3)
			{
				ShowFirstClassPassengers();
			}
			else if (choice == 4)
			{
				ShowEconomyClassPassengers();
			}
			else if (choice == 5)
			{
				ShowAllPassengers();
			}
		}

		private static void BookFirstClass()
		{
			int firstClassCount = 0;
			for (int i = 1; i <= _train.Bookings.Count(); i++)
			{
				if (_train.Bookings[i].Passenger != null && _train.Bookings[i].Passenger.GetType() == typeof(PassengerFirst))
				{
					firstClassCount++;
				}
			}

			if (firstClassCount <= _train.Bookings.Count() / 10)
			{
				var temp = CreatePassenger(true);
				AssignSeat(temp);
			}
			else
			{
				Console.WriteLine("Det finns tyvärr inga lediga platser i första klass.");
			}
		}

		private static void BookEconomyClass()
		{
			int economyClassCount = 0;
			for (int i = 1; i <= _train.Bookings.Count(); i++)
			{
				if (_train.Bookings[i].Passenger != null && _train.Bookings[i].Passenger.GetType() == typeof(PassengerEconomy))
				{
					economyClassCount++;
				}
			}

			if (economyClassCount <= _train.Bookings.Count() / 10 * 9)
			{
				var temp = CreatePassenger(false);
				AssignSeat(temp);
			}
			else
			{
				Console.WriteLine("Det finns tyvärr inga lediga platser i ekonomiklass.");
			}
		}

		private static void ShowFirstClassPassengers()
		{
			Console.WriteLine("BOKNINGAR I FÖRSTA KLASS");
			for (int i = 1; i <= _train.Bookings.Count(); i++)
			{
				if (_train.Bookings[i].Passenger.GetType() == typeof(PassengerFirst))
				{
					_train.Bookings[i].Print();
				}
			}
		}

		private static void ShowEconomyClassPassengers()
		{
			Console.WriteLine("BOKNINGAR I EKONOMIKLASS");
			for (int i = 1; i <= _train.Bookings.Count(); i++)
			{
				if (_train.Bookings[i].Passenger.GetType() == typeof(PassengerEconomy))
				{
					_train.Bookings[i].Print();
				}
			}
		}

		private static void ShowAllPassengers()
		{
			ShowFirstClassPassengers();
			Console.WriteLine();
			ShowEconomyClassPassengers();
		}

		private static void AssignSeat(Passenger temp)
		{
			Console.WriteLine("Ange önskat platsnummer " + 1 + "-" + _train.Bookings.Count() + " eller lämna fältet tomt för automatisk tilldelning, avsluta med enter: ");
			//int prefSeat = int.Parse(Console.ReadLine());
			int prefSeat = 0;
			while (!int.TryParse(Console.ReadLine(), out prefSeat))
			{

			}

			if (_train.Bookings[prefSeat].Passenger == null)
			{
				_train.Bookings[prefSeat].Passenger = temp;
			}
			else
			{
				int emptySeat = GetEmptySeat();
				_train.Bookings[emptySeat].Passenger = temp;
				Console.WriteLine("Detta platsnummer är upptaget. Du har istället fått platsnummer " + emptySeat + ".");
			}
		}

		private static int GetEmptySeat()
		{
			Random random = new Random();
			int seatNumber;

			do
			{
				seatNumber = random.Next(1, _train.Bookings.Count() + 1);
			} while (_train.Bookings[seatNumber].Passenger != null);

			return seatNumber;
		}

		private static Passenger CreatePassenger(bool isFirstClassPassenger)
		{
			Console.WriteLine("Namn: " );
			string namn = Console.ReadLine();
			Console.WriteLine("Syfte: ");
			string objective = Console.ReadLine();
			string extra;

			if (isFirstClassPassenger)
			{
				Console.WriteLine("Sovstol (ja/nej): ");
				extra = Console.ReadLine();

				return new PassengerFirst(namn, objective, extra);
			}

			Console.WriteLine("Lunch (ja/nej): ");
			extra = Console.ReadLine();

			return new PassengerEconomy(namn, objective, extra);
		}
	}
}
