using System;

namespace ReseBokare
{
	public class EconomyClassRegistration : Registration
	{
		private static EconomyClassPassenger[] _list;
		private static int _listCounter;

		public EconomyClassRegistration(int totalNumberOfSeatsInClass)
		{
			_list = new EconomyClassPassenger[totalNumberOfSeatsInClass];
			_listCounter = totalNumberOfSeatsInClass;
		}

		public override Passenger[] List()
		{
			return _list;
		}
		
		public override int ListCounter()
		{
			return _listCounter;
		}

		public override void DecrementListCounter()
		{
			_listCounter--;
		}

		public override Passenger CreatePassenger()
		{
			Console.WriteLine("Namn: ");
			string name = Console.ReadLine();
			Console.WriteLine("Syfte med resan: ");
			string objective = Console.ReadLine();
			Console.WriteLine("Lunch (Ja/Nej): ");
			string lunch = Console.ReadLine();
			while (lunch.ToLower() != "ja" && lunch.ToLower() != "nej")
			{
				Console.WriteLine("Ange ditt val som \"ja\" eller \"nej\":");
				lunch = Console.ReadLine();
			}

			return new EconomyClassPassenger(name, objective, lunch);
		}
	}
}
