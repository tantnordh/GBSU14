using System;

namespace ReseBokare
{
	public class EconomyClassPassenger : Passenger
	{
		public string Lunch { get; set; }

		public override void Print()
		{
			Console.WriteLine("Namn: " + Name);
			Console.WriteLine("Syfte: " + Objective);
			Console.WriteLine("Lunch: " + Lunch);
		}

		public EconomyClassPassenger(string name, string objective, string lunch)
			: base(name, objective)
		{
			Lunch = lunch;
		}
	}
}
