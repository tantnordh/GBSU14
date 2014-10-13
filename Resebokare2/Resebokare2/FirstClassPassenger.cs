using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokare2
{
	public class FirstClassPassenger : Passenger
	{
		public string Sleeper { get; set; }

		public FirstClassPassenger(string name, string objective, string sleeper)
			: base(name, objective)
		{
			Name = name;
			Objective = objective;
			Sleeper = sleeper;
		}
	}
}
