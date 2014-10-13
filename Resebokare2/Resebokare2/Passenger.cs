using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokare2
{
	public abstract class Passenger
	{
		public string Name { get; set; }
		public string Objective { get; set; }
		public abstract string Extra { get; set;}

		public Passenger(string name, string objective)
		{
			Name = name;
			Objective = objective;
		}
	}
}
