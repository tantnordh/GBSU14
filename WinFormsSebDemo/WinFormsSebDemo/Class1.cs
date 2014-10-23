using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsSebDemo
{
	public enum Day : int
	{
		Monday = 0,
		Tuesday = 2,
		Wednesday = 4,
		Thursday = 6,
		Friday = 8,
		Saturday = 10,
		Sunday = 12
	}

	class Class1
	{
		public Class1()
		{
			Day day = Day.Monday;
		}
	}
}
