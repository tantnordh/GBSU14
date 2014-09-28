using System;

namespace ReseBokare
{
	public abstract class Passenger
	{
		public abstract void Print();
		public string Name { get; set; }
		public string Objective { get; set; }

		public Passenger(string name, string objective)
		{
			Name = name;
			Objective = objective;
		}
	}
}
