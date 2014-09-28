using System;

namespace ReseBokare
{
	public class FirstClassPassenger : Passenger
	{
		public string Sleeper { get; set; }

		public override void Print()
		{
			Console.WriteLine("Namn: " + Name);
			Console.WriteLine("Syfte: " + Objective);
			Console.WriteLine("Sovplats: " + Sleeper);
		}

		public FirstClassPassenger(string name, string objective, string sleeper)
			: base(name, objective)
		{
			Sleeper = sleeper;
		}
	}
}
