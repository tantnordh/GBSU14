﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokare2
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
