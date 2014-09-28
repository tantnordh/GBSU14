using System;

namespace ReseBokare
{
	public class FirstClassRegistration : Registration
	{
		private static FirstClassPassenger[] _list;
		private static int _listCounter;

		public FirstClassRegistration(int totalNumberOfSeatsInClass)
		{
			_list = new FirstClassPassenger[totalNumberOfSeatsInClass];
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
			Console.WriteLine("Sovstol (Ja/Nej): ");
			string sleeper = Console.ReadLine();
			while (sleeper.ToLower() != "ja" && sleeper.ToLower() != "nej")
			{
				Console.WriteLine("Ange ditt val som \"ja\" eller \"nej\":");
				sleeper = Console.ReadLine();
			}

			return new FirstClassPassenger(name, objective, sleeper);
		}
	}
}
