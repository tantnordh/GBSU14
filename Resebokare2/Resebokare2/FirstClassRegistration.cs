using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokare2
{
	public class FirstClassRegistration : Registration
	{
		private static string _name;
		private static string _objective;
		private static string _sleeper;
		
		public override Passenger NewPassenger 
		{
			get { return NewPassenger; }
			set { NewPassenger = new FirstClassPassenger(_name, _objective, _sleeper) ; }
		}

		public override void CreatePassenger()
		{
			Console.WriteLine("Namn: ");
			_name = Console.ReadLine();
			Console.WriteLine("Syfte med resan: ");
			_objective = Console.ReadLine();
			Console.WriteLine("Sovstol (Ja/Nej): ");
			_sleeper = Console.ReadLine();
			while (_sleeper.ToLower() != "ja" && _sleeper.ToLower() != "nej")
			{
				Console.WriteLine("Ange ditt val som \"ja\" eller \"nej\":");
				_sleeper = Console.ReadLine();
			}
		}

		public FirstClassRegistration(Seat[] seats, List<FirstClassRegistration> registry) : base(seats, registry) {}
	}
}
