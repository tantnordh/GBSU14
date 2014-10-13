using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokare2
{
	public class PassengerFirst : Passenger
	{
		public override string Extra { get; set; }

		public PassengerFirst(string name, string objective, string sleeper)
			: base(name, objective)
		{
			Name = name;
			Objective = objective;
			Extra = sleeper;
		}
	}
}
