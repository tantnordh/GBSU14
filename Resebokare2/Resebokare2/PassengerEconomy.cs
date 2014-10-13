using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokare2
{
	public class PassengerEconomy : Passenger
	{
		public override string Extra { get; set; }

		public PassengerEconomy(string name, string objective, string lunch)
			: base(name, objective)
		{
			Name = name;
			Objective = objective;
			Extra = lunch;
		}
	}
}
