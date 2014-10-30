using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOchDelegater
{
	public class EventRunTwo
	{
		public event MyMethodDesc2 KingsNamingEvent;

		public EventRunTwo()
		{
			Console.WriteLine("- Test av event -");
		}

		public void PrintThings()
		{
			Console.WriteLine("Your name as King is:");
			KingsNamingEvent("Henry", 8);
		}
	}
}
