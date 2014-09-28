using System;

namespace ReseBokare
{
	class Program
	{
		private static FirstClassRegistration _firstClass = new FirstClassRegistration(10);
		private static EconomyClassRegistration _economyClass = new EconomyClassRegistration(90);

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
			Console.WriteLine("Antal lediga platser i Första klass är " + _firstClass.ListCounter() + " och i ekonomiklass " + _economyClass.ListCounter());
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
				NewFirstClassPassenger();
			}
			else if (choice == 2)
			{
				NewEconomyClassPassenger();
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

		private static void NewFirstClassPassenger()
		{
			if (_firstClass.ListCounter() > 0)
			{
				_firstClass.PassengerRegistration();
			}
			else
			{
				Console.WriteLine("Det finns inga lediga platser i första klass.");
			}
		}

		private static void NewEconomyClassPassenger()
		{
			if (_economyClass.ListCounter() > 0)
			{
				_economyClass.PassengerRegistration();
			}
			else
			{
				Console.WriteLine("Det finns inga lediga platser i ekonomiklass.");
			}
		}

		private static void ShowFirstClassPassengers()
		{
			for (int i = 0; i < _firstClass.List().Length; i++)
			{
				if (_firstClass.List()[i] != null)
				{
					Console.WriteLine("Stolsnummer: " + (i + 1));
					_firstClass.List()[i].Print();
					Console.WriteLine();
				}
			}
		}

		private static void ShowEconomyClassPassengers()
		{
			for (int i = 0; i < _economyClass.List().Length; i++)
			{
				if (_economyClass.List()[i] != null)
				{
					Console.WriteLine("Stolsnummer: " + (i + 1));
					_economyClass.List()[i].Print();
					Console.WriteLine();
				}
			}
		}

		private static void ShowAllPassengers()
		{
			Console.WriteLine("Passagerare i första klass:");
			ShowFirstClassPassengers();
			Console.WriteLine("Passagerare i ekonomiklass:");
			ShowEconomyClassPassengers();
		}
	}
}
